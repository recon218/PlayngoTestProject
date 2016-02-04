using PLAYnGO_TestProject.Models;

namespace PLAYnGO_TestProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PLAYnGO_TestProject.Models.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PLAYnGO_TestProject.Models.DatabaseContext context)
        {
            context.Profiles.AddOrUpdate(
                new Profile { Firstname = "Reynan", Lastname = "Capco", Address = "Cavite", ContactNo = "123" },
                new Profile { Firstname = "Brad", Lastname = "Pitt", Address = "US", ContactNo = "234" },
                new Profile { Firstname = "Leonardo", Lastname = "Decarpio", Address = "US", ContactNo = "345" },
                new Profile { Firstname = "Will", Lastname = "Smith", Address = "US", ContactNo = "456" }
                );
        }
    }
}
