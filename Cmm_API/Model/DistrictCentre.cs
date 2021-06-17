using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cmm_API.Model
{
    public class DistrictCentre
    {
        public string dc_name_en { get; set; }

        public List<CountingCentre> ListofCountingCentreModel { get; set; }
    }
}
