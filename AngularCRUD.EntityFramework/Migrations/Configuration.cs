namespace AngularCRUD.Migrations
{
    using System.Data.Entity.Migrations;

    using AngularCRUD.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<AngularCRUDDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
            this.ContextKey = "AngularCRUD";
        }

        protected override void Seed(AngularCRUDDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
