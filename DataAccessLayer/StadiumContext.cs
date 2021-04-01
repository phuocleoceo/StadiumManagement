using DataAccessLayer.Models;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class StadiumContext : DbContext
    {
        public StadiumContext() : base("name=CNS")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountInformation> AccountInformation { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<RentOrder> RentOrders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceOrder> ServiceOrders { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }

    }
}
