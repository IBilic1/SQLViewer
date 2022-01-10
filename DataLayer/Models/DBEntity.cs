using DataLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class DBEntity
    {
        public string Name { get; set; }
        public string Schema { get; set; }
        public Database Database { get; set; }

        private Lazy<IEnumerable<Column>> columns;
        public DBEntity()
        {
            columns = new Lazy<IEnumerable<Column>>(() => RepositoryFactory.GetRepository().GetColumns(this));
        }
        public IList<Column> Columns
        {
            get => new List<Column>(columns.Value);
        }
        public override string ToString() => $"{Schema}.{Name}";
    }
}
