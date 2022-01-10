using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class DBResult
    {
        private const string formatRows = "({0} row{1} affected)";
        private const string formatTime = "Completion time: {0}";

        public DataSet DataSet { get; set; }
        public long RowsAffected { get; set; }
        public DateTime CompletionTime { get; set; }
        public string Message 
        {
            get
            {
                if (RowsAffected <= 1)
                    return string.Format(formatRows, RowsAffected, "");
                else
                    return string.Format(formatRows, RowsAffected, "s");
            }
        }


    }
}
