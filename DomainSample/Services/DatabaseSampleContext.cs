using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DomainSample.Services
{
    public class DatabaseSampleContext : DbContext
    {
        public DatabaseSampleContext() : base(ConfigurationManager.ConnectionStrings["DatabaseSample"].ConnectionString)
        {
            var ensureDllIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<Models.Customer> Customers { get; set; }
        public DbSet<Models.Order> Orders { get; set; }
        public DbSet<Models.OrderLine> OrderLines { get; set; }
        public DbSet<Models.Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
