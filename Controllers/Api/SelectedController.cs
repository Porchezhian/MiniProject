using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FreeLancer.Models;

namespace FreeLancer.Controllers.Api
{
    public class SelectedController : ApiController
    {
        private FreeLancerDBContext context;

        public SelectedController()
        {
            context = new FreeLancerDBContext();
        }

        //POST api/selected
        public Selected CreateSelected([FromBody]Selected selected)
        {
            context.Selecteds.Add(selected);
            context.SaveChanges();

            return selected;
        }
    }
}
