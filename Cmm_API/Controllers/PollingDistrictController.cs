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

       
    }
}
