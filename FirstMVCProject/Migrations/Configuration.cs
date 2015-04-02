namespace FirstMVCProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FirstMVCProject.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FirstMVCProject.Models.MovieDBContext";
        }

        protected override void Seed(FirstMVCProject.Models.MovieDBContext context)
        {
            
        }
    }
}
