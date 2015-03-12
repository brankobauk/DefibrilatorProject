using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DefibrilatorProject.Models.Models
{
    public class Company
    {
        public Company()
        {
            UserProfiles = new List<UserProfile>();
            SoldProducts = new List<SoldProduct>();
        }
        [Key]
        public int CompanyId { get; set; }
        public string Name { get; set; }
        private ICollection<UserProfile> UserProfiles { get; set; }
        private ICollection<SoldProduct> SoldProducts { get; set; }
    }
}