using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SQLVIewer
{
    class ParseQuery
    {
        private const string WHERE_REGEX = " WHERE [a-zA-Z0-9.()!' ]*=[ ]*[a-zA-Z0-9.()!']*";
        private const string REGEX = " [a-zA-Z0-9]*";
        private const string SELECT_REGEX = "SELECT [A-Za-z*]* FROM [a-zA-Z]*";
        private const string INSERT_REGEX = "INSERT INTO [a-zA-Z0-9]* VALUES[ ]*[a-zA-Z0-9(),']*";
        private const string DELETE_REGEX = "DELETE FROM [a-zA-Z0-9]*";
        private const string UPDATE_REGEX = "UPDATE [a-zA-Z0-9]* SET [a-zA-Z0-9='',.]*";
        private const string CREATE_REGEX = @"CREATE [ a-zA-Z0-9]*\([a-z A-Z0-9='',.()]*\)";
        private const string ALTER_REGEX = @"ALTER TABLE [a-zA-Z0-9]* ADD [a-zA-Z0-9]* [a-zA-Z0-9().,]*";
        private const string DROP_REGEX = "DROP TABLE [a-zA-Z0-9]*";
        private static IList<string> regexs = new List<string>() { SELECT_REGEX, INSERT_REGEX, DELETE_REGEX, UPDATE_REGEX, CREATE_REGEX, ALTER_REGEX, DROP_REGEX };

        private static IList<string> querys = new List<string>();
        private static StringBuilder makeingQuery = new StringBuilder();
        private static StringBuilder tempQuery = new StringBuilder();
        public static IList<bool> isValidSyntax = new List<bool>();
        public ParseQuery()
        {
            querys = new List<string>();
            makeingQuery = new StringBuilder();
            tempQuery = new StringBuilder();
        }
        public IList<string> devideQueryNew(string[] details, int index)
        {
            if (details.Length == index)
            {
                if (tempQuery.ToString().Length != 0)
                {
                    querys.Add(tempQuery.ToString());
                }
                if (isValidSyntax[isValidSyntax.Count-1]==false)
                {
                    throw new Exception("Invalid syntaxxx");
                }
                return querys;
            }

            if (!string.IsNullOrEmpty(details[index]))
            {
                makeingQuery.Append(details[index].Trim()).Append(" ");
                //citaj sve dok je tocno
                if (isValidQuery(makeingQuery))  
                {
                    isValidSyntax.Add(true);
                    clearBuilder(tempQuery);
                    tempQuery.Append(makeingQuery.ToString().Trim());
                }
                else
                { 
                    //ako nije dobro, sve prethodno sto je dobro dodaj u lisutu
                    isValidSyntax.Add(false);
                    if (tempQuery.ToString().Length != 0)
                    {
                        querys.Add(tempQuery.ToString().Trim());
                        clearBuilder(tempQuery,makeingQuery);
                        isValidSyntax.Add(true);
                        makeingQuery.Append(details[index]).Append(" ");
                        if (isValidQuery(makeingQuery))  // ukoliko je ostatk dobar, pocmi graditi novi query
                        {
                            tempQuery.Append(makeingQuery.ToString().Trim()); // za slucaj da je ovo zadnji prolaz kroz rekurziju addaj mi u tempQuery
                            return devideQueryNew(details, ++index);
                        }
                    }
         
                    isValidSyntax.Add(false);
                }
            }

            return devideQueryNew(details, ++index);
        }
        private void clearBuilder(params StringBuilder[] builder)
        {
            foreach (StringBuilder item in builder)
            {
                item.Clear();
            }
        }
        
        private bool isValidQuery(StringBuilder builder)
        {
            string query = builder.ToString().ToUpper().Trim();
            foreach (string regex in regexs)
            {
                if (Regex.Match(query, regex).Value == query)
                {
                    return true;
                }
                if (Regex.Match(query, regex + WHERE_REGEX).Value == query)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
