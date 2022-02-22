using DomainSample.Models;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DomainSample.Services
{
    public class DatabaseSampleContext : DbContext
    {
        public DatabaseSampleContext() : base(ConfigurationManager.ConnectionStrings["DatabaseSample"].ConnectionString)
        {
        }

        public DbSet<Models.Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
