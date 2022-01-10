using DataLayer.Models;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataLayer.DAL
{
    public interface IRepository
    {
        IEnumerable<Column> GetColumns(DBEntity dBEntity);
        IEnumerable<Database> GetDatabases();
        IEnumerable<DBEntity> GetDBEntity(Database database, DBEntityType dBEntityType);
        IEnumerable<Parameter> GetParameters(Procedure procedure);
        IEnumerable<Procedure> GetProcedures(Database database);
        void Login(string server, string username, string password);
        DataSet CreateDataSet(DBEntity entity);
        DBResult CreateDataSet(string query, Database database);
    }
}