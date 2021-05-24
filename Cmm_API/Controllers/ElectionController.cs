﻿using Cmm_API.Operation;
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
    public class ElectionController : ControllerBase
    {

        private cmm_operation operation;

        public ElectionController(cmm_operation operation1)
        {
            this.operation = operation1;
        }

        // GET: api/<ElectionController>
        [HttpGet]
        public object GetElectionDetailsAPI()
        {
            object obj = this.operation.GetElectionDetailsAPI();
            return obj;
        }

        // GET: api/<ElectionController>
        [HttpGet]
        public object GetActiveElectionDetailsAPI()
        {
            object obj = this.operation.GetActiveElectionDetailsAPI();
            return obj;
        }

        
    }
}
