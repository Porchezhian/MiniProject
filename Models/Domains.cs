using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeLancer.Models
{
    public class Domains
    {
        public int Id { get; set; }
        public string Domain { get; set; }
        public int Vacany { get; set; }
        public ICollection<Freelancer> Freelancers { get; set; }
    }
}