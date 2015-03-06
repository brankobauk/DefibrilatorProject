using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DefibrilatorProject.Models.Models
{
    public class UserData
    {
        public int UserDataId { get; set; }
        public int UserId { get; set; }
        public int CompanyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual UserProfile UserProfiles { get; set; }
        public virtual Company Company { get; set; }
    }
}