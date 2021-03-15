using Cmm_API.Operation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cmm_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ElectoralDistrictController : ControllerBase
    {
        private cmm_operation operation;

        public ElectoralDistrictController(cmm_operation operation1)
        {
            this.operation = operation1;
        }

        // GET: api/<ElectoralDistrictController>
        [HttpGet]
        public object GetElectoralDistrict()
        {
            object obj = this.operation.GetAll("ElectoralDistrict");
            return obj;
        }

        // GET api/<ElectoralDistrictController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ElectoralDistrictController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ElectoralDistrictController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ElectoralDistrictController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
