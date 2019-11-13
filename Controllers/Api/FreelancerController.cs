using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FreeLancer.Models;

namespace FreeLancer.Controllers.Api
{
    public class FreelancerController : ApiController
    {
        private FreeLancerDBContext context;

        public FreelancerController()
        {
            context = new FreeLancerDBContext();
        }
        //POST api/freelancer
        [HttpPost]
        public Freelancer CreateFreeLancer(Freelancer freelancer)
        {
            context.FreeLancers.Add(freelancer);
            context.SaveChanges();

            return freelancer;
        }
    }
}
