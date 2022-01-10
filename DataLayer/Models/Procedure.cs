using DataLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Procedure
    {
        public string Name { get; set; }
        public string Definition { get; set; }
        public Database Database { get; set; }

        private Lazy<IEnumerable<Parameter>> parameters;
        public Procedure()
        {
            parameters = new Lazy<IEnumerable<Parameter>>(() => RepositoryFactory.GetRepository().GetParameters(this));
        }
        public IList<Parameter> Parameters
        {
            get => new List<Parameter>(parameters.Value);
        }

        public override string ToString() => Name;
    }
}
