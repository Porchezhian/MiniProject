namespace FreeLancer.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using FreeLancer.Models;

    public class FreeLancerDBContext : DbContext
    {
        
        public FreeLancerDBContext()
            : base("name=FreeLancerDBContext")
        {
        }
        public DbSet<Selected> Selecteds { get; set; }
        public DbSet<Freelancer> FreeLancers { get; set; }
        public DbSet<Hirer> Hirers { get; set; }
    }
}
