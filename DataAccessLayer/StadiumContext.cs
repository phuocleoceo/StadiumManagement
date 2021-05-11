using DataAccessLayer.Models;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class StadiumContext : DbContext
    {
        //public StadiumContext() : base("name=VPSOnline"){}
        public StadiumContext() : base("name=CNS"){}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountInformation> AccountInformation { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<RentOrder> RentOrders { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceOrder> ServiceOrders { get; set; }
        public virtual DbSet<Stadium> Stadiums { get; set; }

    }
}
