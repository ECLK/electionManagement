using Cmm_API.Operation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cmm_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdminDistrictController : ControllerBase
    {
        private cmm_operation operation;

        public AdminDistrictController(cmm_operation operation1)
        {
            this.operation = operation1;
        }

        // GET: api/<AdminDistrictController>
        [HttpGet]
        public object GetAdminDistrict()
        {
            object obj = this.operation.GetAll("AdminDistrict");
            return obj;
        }

        // GET api/<AdminDistrictController>/5
        [HttpGet]
        public object GetHierarchy()
        {
            object obj = this.operation.GetHierarchy();
            return obj;
        }

        [HttpGet]
        public object GetA()
        {
            object obj = this.operation.GetA();
            return obj;
        }

        [HttpGet]
        public object GettestHierarchy()
        {
            object obj = this.operation.GettestHierarchy();
            return obj;
        }


        


        // POST api/<AdminDistrictController>
        // [HttpPost]
        // public void Post([FromBody] string value)
        //{
        //}

        // PUT api/<AdminDistrictController>/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        //}

        // DELETE api/<AdminDistrictController>/5
        // [HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
