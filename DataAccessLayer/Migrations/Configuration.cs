namespace DataAccessLayer.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.StadiumContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DataAccessLayer.StadiumContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Accounts.Add(new Models.Account
            {
                Id = 1,
                UserName = "admin",
                PassWord = "c4ca4238a0b923820dcc509a6f75849b",
                Role = Enums.Role.Admin,
                Image = default
            });
            context.Accounts.AddOrUpdate();
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
