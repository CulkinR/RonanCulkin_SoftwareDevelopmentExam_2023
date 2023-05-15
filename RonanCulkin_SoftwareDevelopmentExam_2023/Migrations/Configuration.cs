namespace RonanCulkin_SoftwareDevelopmentExam_2023.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RonanCulkin_SoftwareDevelopmentExam_2023.MovieData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "RonanCulkin_SoftwareDevelopmentExam_2023.MovieData";
        }

        protected override void Seed(RonanCulkin_SoftwareDevelopmentExam_2023.MovieData context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
