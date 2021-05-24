using Cmm_API.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Cmm_API.Controllers
{
    public class CommonMethodController
    {
        /// <summary>
        /// return province object with relevant data
        /// </summary>
        /// <param name="rows"></param>
        /// <returns></returns>
        public Province GetProvinceDetails(List<DataRow> rows)
        {

            var pObj = new Province();
            var elec = new List<ElectoralDistrict>();

            if (rows.Count > 0)
            {
                foreach (var row in rows)
                {
                    pObj.province_name_en = row[0].ToString();
                    var district = new ElectoralDistrict() { ed_name_en = row[1].ToString(), number_of_seats = Int32.Parse(row[2].ToString()) };
                    elec.Add(district);

                }
                pObj.ListofElectoralDistrictModel = elec;
            }

            return pObj;
        }
    }
}
