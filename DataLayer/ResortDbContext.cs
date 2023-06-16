using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ResortDbContext : DbContext
    {
        public ResortDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }
        public DbSet<Client> MyProperty { get; set; }
    }
}
