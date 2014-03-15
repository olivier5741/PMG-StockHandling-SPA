using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication6.Controllers
{
    public class StockController : ApiController
    {
        // GET api/stock
        public IEnumerable<string> Get()
        {
            return new string[] { "Salut Rossana", "value2" };
        }

        // GET api/stock/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/stock
        public void Post([FromBody]string value)
        {
        }

        // PUT api/stock/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/stock/5
        public void Delete(int id)
        {
        }
    }
}
