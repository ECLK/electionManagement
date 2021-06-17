using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cmm_API.Model
{
    public class AdminDistrict
    {
       // public string admin_dis_id { get; set; }

        public string admin_dis_name_en { get; set; }

      //  public string admin_dis_name_si { get; set; }

       // public string admin_dis_name_ta { get; set; }

        //public string itteration_id { get; set; }

        //public string province_id { get; set; }

        //public string ed_id { get; set; }

        public List<Party> ListofPartyModel { get; set; }

        public List<DistrictCentre> ListofDistrictCentreModel { get; set; }
    }
}
