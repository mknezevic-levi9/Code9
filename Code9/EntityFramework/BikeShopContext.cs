using System.Data.Entity;

namespace EntityFramework
{
    public class BikeShopContext : DbContext
    {
        public BikeShopContext()
            : base()
            //: base("name=BikeShopConnectionString")
        {
            //Database.SetInitializer<BikeShopContext>(new DropCreateDatabaseAlways<BikeShopContext>());
        }

        public DbSet<Bicycle> Bicycles { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
