using Cmm_API.Model;
using Cmm_API.Operation;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cmm_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CountingCentreController : ControllerBase
    {
        private cmm_operation operation;

        public CountingCentreController(cmm_operation operation1)
        {
            this.operation = operation1;
        }

        // GET: api/<CountingCenterController>
        //[HttpGet]
        //public object GetCountingCentre()
        //{
        //    object obj = this.operation.GetAll("CountingCentre");
        //    return obj;
        //}


        [HttpGet]
        public object GetPostalCountingCenterAPI()
        {
            object obj = this.operation.GetPostalCountingCenterAPI();
            return obj;
        }

        [HttpGet]
        public string GetPostalCountingCenterDatasetAPI()
        {
            var provincelist = this.operation.GetPostalCountingCenterAPI();

            if (provincelist.Rows.Count <= 0)
                return null;

            var provinceObj = new List<Province>();

            List<DataRow> drList = new List<DataRow>();

            foreach (DataRow dr in provincelist.Rows)
            {
                drList.Add(dr);
            }

            var provinces = drList.GroupBy(x => x.ItemArray[0]);

            foreach (var item in provinces)
            {
                provinceObj.Add(new CommonMethodController().GetProvinceDetailsforPostalCountingAPI(item.ToList()));
            }

            var countingtype = JsonConvert.SerializeObject(provinceObj);

            return countingtype;
        }

        // GET api/<CountingCenterController>/5
        //[HttpGet("{id}")]
        //public object GetCountingCentreDetails(int id)
        //{
        //    object obj = this.operation.GetCountingCentreDetails(id);
        //    return obj;
        //}

    }
}
