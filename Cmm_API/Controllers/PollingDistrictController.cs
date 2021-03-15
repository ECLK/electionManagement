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
    public class PollingDistrictController : ControllerBase
    {
        private cmm_operation operation;

        public PollingDistrictController(cmm_operation operation1)
        {
            this.operation = operation1;
        }


        // GET: api/<PollingDistrictController>
        [HttpGet]
        public object GetPollingDistrict()
        {
            object obj = this.operation.GetAll("PollingDistrict");
            return obj;
        }

        // GET api/<PollingDistrictController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PollingDistrictController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PollingDistrictController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PollingDistrictController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
