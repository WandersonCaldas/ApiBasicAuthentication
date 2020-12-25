using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace src.Controllers
{
    [Authentication.BasicAuthentication]
    public class HomeController : ApiController
    {
        // GET: api/Home                
        public IHttpActionResult Get()
        {
            return Ok();
        }

        // GET: api/Home/5        
        public IHttpActionResult Get(int id)
        {
            return Ok();
        }

        // POST: api/Home        
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Home/5        
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Home/5        
        public void Delete(int id)
        {
        }
    }
}
