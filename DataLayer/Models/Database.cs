using DataLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Database
    {
        public string Name { get; set; }
        private Lazy<IEnumerable<DBEntity>> tables;
        private Lazy<IEnumerable<DBEntity>> views;
        private Lazy<IEnumerable<Procedure>> procedures;
        public Database()
        {
            tables = new Lazy<IEnumerable<DBEntity>>(()=> RepositoryFactory.GetRepository().GetDBEntity(this,DBEntityType.Table));
            views = new Lazy<IEnumerable<DBEntity>>(()=> RepositoryFactory.GetRepository().GetDBEntity(this,DBEntityType.View));
            procedures = new Lazy<IEnumerable<Procedure>>(()=> RepositoryFactory.GetRepository().GetProcedures(this));
        }
        public IList<DBEntity> Tables
        {
            get => new List<DBEntity>(tables.Value);
        }
        public IList<DBEntity> Views
        {
            get => new List<DBEntity>(views.Value);
        }
        public IList<Procedure> Procedures
        {
            get => new List<Procedure>(procedures.Value);
        }
        public override string ToString() => Name;
    }
}
