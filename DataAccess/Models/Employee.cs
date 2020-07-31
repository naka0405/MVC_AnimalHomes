using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Employee:IdentityUser
    {
        public string City { get; set; }
       // public int Id { get; set; }
        public DateTime BirthDate { get; set; }
        public string LastName { get; set; }
    }
}
