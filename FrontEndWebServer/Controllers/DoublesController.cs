using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using System.Fabric;
using Microsoft.ServiceFabric.Services.Remoting.Client;

namespace FrontEndWebServer.Controllers
{
    [Route("api/[controller]")]
    public class DoublesController : Controller
    {

        // GET api/doubles
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string NoNumber = "No Number Provided.";
            System.Diagnostics.Trace.WriteLine(NoNumber);
            return new string[] { NoNumber };
        }

        // GET api/doubles/5
        [HttpGet("{number}")]
        public IEnumerable<string> Get(double number)
        {
            double numberDoubled = 0;
            numberDoubled = Math.Pow(number, 2);

            System.Diagnostics.Trace.WriteLine(String.Format("Number Doubled: {0}", numberDoubled));
            return new string[] { numberDoubled.ToString() };
        }

        // POST api/doubles
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/doubles/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/doubles/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
