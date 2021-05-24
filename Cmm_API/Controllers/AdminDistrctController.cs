using Cmm_API.Operation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

        //[HttpGet]
        //public object Getsheets()
        //{
        //    string[,] districtdata;
        //    DataTable province = this.operation.GetAll_table("province");
        //    for(int i=0; i < province.Rows.Count; i++)
        //    {
        //        string province_id = province.Rows[i]["province_id"].ToString();
        //        DataTable distri = this.operation.Getbyid("province",province_id, "province_id");
        //        for (int j = 0; j < distri.Rows.Count; j++)
        //        {
        //            districtdata = new string[,]
        //            {
        //               { province.Rows[i]["province_name_en"].ToString(),distri.Rows[j]["admin_dis_name_en"].ToString() }
        //            };
        //        }
        //    }

        //    return "";
        //}

        //[HttpGet]
        //public object Getsheets1()
        //{
        //    DataTable province = this.operation.GetAll_table("province");
        //    string JSONString = string.Empty;
        //    JSONString = JsonConvert.SerializeObject(province);

        //    var jo = JObject.Parse(JSONString);
        //    return jo;
        //}



        // GET api/<AdminDistrictController>/5
        [HttpGet]
        public object GetHierarchy()
        {
            object obj = this.operation.GetHierarchy();
            return obj;
        }

        //[HttpGet]
        //public object GetA()
        //{
        //    object obj = this.operation.GetA();
        //    return obj;
        //}

        //[HttpGet]
        //public object GettestHierarchy()
        //{
        //    object obj = this.operation.GettestHierarchy();
        //    return obj;
        //}


        


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
