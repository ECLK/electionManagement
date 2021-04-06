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
    public class DistrictCenterController : ControllerBase
    {
        private cmm_operation operation;

        public DistrictCenterController(cmm_operation operation1)
        {
            this.operation = operation1;
        }

        // GET: api/<DistrictCenterController>
        [HttpGet]
        public object GetDistrictCenter()
        {
            object obj = this.operation.GetAll("DistrictCenter");
            return obj;
        }

        // GET api/<DistrictCenterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DistrictCenterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DistrictCenterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DistrictCenterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
