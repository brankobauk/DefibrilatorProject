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
            UsersData = new List<UserData>();
        }
        [Key]
        public int CompanyId { get; set; }
        public string Name { get; set; }
        private ICollection<UserData> UsersData { get; set; }
    }
}