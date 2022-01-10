using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DAL
{
    class Repository : IRepository
    {
        private static string cs;

        private const string ConnectionString = "Server={0};Uid={1};Pwd={2}";
        private const string SelectDatabases = "SELECT name As Name from sys.databases";
        private const string SelectTables = "SELECT TABLE_SCHEMA AS [Schema], TABLE_NAME AS Name FROM {0}.INFORMATION_SCHEMA.TABLES";
        private const string SelectViews = "SELECT TABLE_SCHEMA AS [Schema], TABLE_NAME AS Name FROM {0}.INFORMATION_SCHEMA.VIEWS";
        private const string SelectProcedures = "SELECT SPECIFIC_NAME as Name, ROUTINE_DEFINITION as Definition FROM {0}.INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_TYPE = 'PROCEDURE'";
        private const string SelectColumns = "SELECT COLUMN_NAME as Name, DATA_TYPE as DataType FROM {0}.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{1}'";
        private const string SelectProcedureParameters = "SELECT PARAMETER_NAME as Name, PARAMETER_MODE as Mode, DATA_TYPE as DataType FROM {0}.INFORMATION_SCHEMA.PARAMETERS WHERE SPECIFIC_NAME='{1}'";
        private const string SelectQuery = "SELECT * FROM {0}.{1}.{2}";
        public void Login(string server, string username, string password)
        {
            using (SqlConnection con = new SqlConnection(string.Format(ConnectionString, server, username, password)))
            {
                cs = con.ConnectionString;
                con.Open();
            }
        }
        public IEnumerable<Database> GetDatabases()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = SelectDatabases;
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new Database
                            {
                                Name = dr[nameof(Database.Name)].ToString()
                            };
                        }
                    }
                }
            }
        }
        public IEnumerable<DBEntity> GetDBEntity(Database database, DBEntityType dBEntityType)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    switch (dBEntityType)
                    {
                        case DBEntityType.Table:
                            cmd.CommandText = string.Format(SelectTables, database.Name);
                            break;
                        case DBEntityType.View:
                            cmd.CommandText = string.Format(SelectViews, database.Name);
                            break;
                        default:
                            break;
                    }
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new DBEntity
                            {
                                Name = dr[nameof(Database.Name)].ToString(),
                                Schema = dr[nameof(DBEntity.Schema)].ToString(),
                                Database = database
                            };
                        }
                    }
                }
            }
        }

        public IEnumerable<Procedure> GetProcedures(Database database)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format(SelectProcedures, database.Name);
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new Procedure
                            {
                                Name = dr[nameof(Database.Name)].ToString(),
                                Definition = dr[nameof(Procedure.Definition)].ToString(),
                                Database = database
                            };
                        }
                    }
                }
            }
        }

        public IEnumerable<Column> GetColumns(DBEntity dBEntity)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format(SelectColumns, dBEntity.Database.Name, dBEntity.Name);
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new Column
                            {
                                Name = dr[nameof(Database.Name)].ToString(),
                                DataType = dr[nameof(Column.DataType)].ToString()
                            };
                        }
                    }
                }
            }
        }

        public IEnumerable<Parameter> GetParameters(Procedure procedure)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format(SelectProcedureParameters, procedure.Database.Name, procedure.Name);
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new Parameter
                            {
                                Name = dr[nameof(Parameter.Name)].ToString(),
                                DataType = dr[nameof(Parameter.DataType)].ToString(),
                                Mode = dr[nameof(Parameter.Mode)].ToString()
                            };
                        }
                    }
                }
            }
        }

        public DataSet CreateDataSet(DBEntity entity)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter(string.Format(SelectQuery, entity.Database, entity.Schema, entity.Name), con);
                DataSet ds = new DataSet(entity.Name);
                da.Fill(ds);
                ds.Tables[0].TableName = entity.Name;
                return ds;
            }
        }
      
        public DBResult CreateDataSet(string query, Database database)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                 con.StatisticsEnabled = true;
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "USE "+database.Name+"\n"+ query;
                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    var stats = con.RetrieveStatistics();
                    var rowsIDU = (long)stats["IduRows"];
                    var rowsSelect= (long)stats["SelectRows"];
                    return new DBResult
                    {
                        DataSet = ds,
                        RowsAffected=rowsIDU==0?rowsSelect:rowsIDU,
                        CompletionTime=DateTime.UtcNow
                    };
                }

            }
        }

    }
}
