using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace PLAYnGO_TestProject.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }
    }
}