﻿using Cmm_API.Operation;
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
    public class CountingCentreController : ControllerBase
    {
        private cmm_operation operation;

        public CountingCentreController(cmm_operation operation1)
        {
            this.operation = operation1;
        }

        // GET: api/<CountingCenterController>
        [HttpGet]
        public object GetCountingCentre()
        {
            object obj = this.operation.GetAll("CountingCentre");
            return obj;
        }

        // GET api/<CountingCenterController>/5
        [HttpGet("{id}")]
        public object GetCountingCentreDetails(int id)
        {
            object obj = this.operation.GetCountingCentreDetails(id);
            return obj;
        }


        //[HttpGet("{id}")]
        //public object GetCountingDetails(int id)
       // {
            //object obj = this.operation.GetCountingDetails(id);
            //return obj;
          //}

        // POST api/<CountingCenterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CountingCenterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CountingCenterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)    
        {
        }
    }
}
