using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PLAYnGO_TestProject.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Address { get; set; }

        public string ContactNo { get; set; }
    }
}