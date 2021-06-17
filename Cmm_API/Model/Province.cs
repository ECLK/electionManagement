using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Cmm_API.Model
{
    public class Province
    {
        //public string province_id { get; set; }

        public string province_name_en { get; set; }

      //  public string province_name_si { get; set; }

       // public string province_name_ta { get; set; }

      //  public string itteration_id { get; set; }

        public List<ElectoralDistrict> ListofElectoralDistrictModel { get; set; }

        public List<AdminDistrict> ListofAdminDistrictModel { get; set; }
    }
}

