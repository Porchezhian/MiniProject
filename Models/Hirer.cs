using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeLancer.Models
{
    public class Hirer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int MobileNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public ICollection<Selected> Selected { get; set; }
    }
}