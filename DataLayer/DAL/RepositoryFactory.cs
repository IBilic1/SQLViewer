using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DAL
{
    public static class RepositoryFactory
    {
        private static readonly Lazy<Repository> repository = new Lazy<Repository>(()=>new Repository());
        public static IRepository GetRepository() => repository.Value;
    }
}
