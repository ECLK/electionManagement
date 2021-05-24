using Cmm_API.Model;
using Cmm_API.Operation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Cmm_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {

        private cmm_operation operation;

        public ProvinceController(cmm_operation operation1)
        {
            this.operation = operation1;
        }


        [HttpGet]
        public object GetSeatsDataAPI()
        {
            object obj = this.operation.GetSeatsDataAPI();
            return obj;
        }



        // GET: ProvinceController
        //[HttpGet]
        //public object GetNumberofSeatsDatasetAPI()
        //{
        //   object obj = this.operation.GetNumberofSeatsDatasetAPI();
        //    return obj;
        //}

        [HttpGet]
        public object GetPartyDatasetAPI()
        {
            object obj = this.operation.GetPartyDatasetAPI();
            return obj;
        }

        [HttpGet]
        public string GetNumberofSeatsDatasetAPI()
        {
            var allprovince = this.operation.GetSeatsDataAPI();

            if (allprovince.Rows.Count <= 0)
                return null;

            var provinceObj = new List<Province>();

            List<DataRow> drList = new List<DataRow>();
            foreach (DataRow dr in allprovince.Rows)
            {
                drList.Add(dr);
            }


            var provinces = drList.GroupBy(x => x.ItemArray[0]);

            foreach (var item in provinces)
            {
                provinceObj.Add(new CommonMethodController().GetProvinceDetails(item.ToList()));
            }

             var numofseat = JsonConvert.SerializeObject(provinceObj);
            //Console.Write(numofseat);

            return numofseat;
        }


    }
}
