using Cmm_API.Operation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cmm_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PollingStationController : ControllerBase
    {
        private cmm_operation operation;

        public PollingStationController(cmm_operation operation1)
        {
            this.operation = operation1;
        }


        // GET: api/<PollingStationController>
        [HttpGet]
        public object GetPollingStation()
        {
            object obj = this.operation.GetAll("PollingStation");
            return obj;
        }

        // GET api/<PollingStationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PollingStationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PollingStationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PollingStationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
