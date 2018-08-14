using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace CodeFirstSample
{
    public class Mycontext:DbContext
    {
        public Mycontext()
            : base("CodeFirstConnection")
        {
            Database.SetInitializer<Mycontext>(new CreateDatabaseIfNotExists<Mycontext>());
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
