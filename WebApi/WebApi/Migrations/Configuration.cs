namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Data.SqlClient;
    using System.Data;
    using System.Configuration;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApi.Models.WebApiContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApi.Models.WebApiContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        }
    }
}
