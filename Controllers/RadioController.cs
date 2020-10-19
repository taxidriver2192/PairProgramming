using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RadioLib;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PairProgramming.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RadioController : ControllerBase
    {
        private static List<Radio> radiolist = new List<Radio>()
        {
            new Radio { }
        };

        // GET: api/<RadioController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }       

        // GET api/<RadioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RadioController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RadioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RadioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
