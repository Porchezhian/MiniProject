using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FreeLancer.Models;

namespace FreeLancer.Controllers.Api
{
    public class HirerController : ApiController
    {
        private FreeLancerDBContext context;

        public HirerController()
        {
            context = new FreeLancerDBContext();
        }

        //POST api/hirer
        [HttpPost]
        public Hirer CreateHirer([FromBody]Hirer hirer)
        {
            context.Hirers.Add(hirer);
            context.SaveChanges();

            return hirer;
        }
    }
}
