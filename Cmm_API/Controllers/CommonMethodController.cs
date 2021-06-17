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


        public Province GetPartyDetails(List<DataRow> rows)
        {
            var pObj2 = new Province();
            var admin = new List<AdminDistrict>();
            var party = new List<Party>();

            if (rows.Count > 0)
            {
                foreach (var row in rows)
                {
                    pObj2.province_name_en = row[0].ToString();

                    var district = new AdminDistrict()
                    {
                        admin_dis_name_en = row[1].ToString(),
                        ListofPartyModel = new List<Party>() {new Party() {
                            party_name = row[2].ToString(), party_abbreviation = row[3].ToString(),
                            party_symbol = row[4].ToString(), color = row[5].ToString(), } }
                    };


                    //var partydetails = new Party() { party_name = row[2].ToString(),party_abbreviation = row[3].ToString(),
                    //    party_symbol= row[4].ToString(), color = row[5].ToString()};

                    //party.Add(partydetails);
                    admin.Add(district);

                }

                pObj2.ListofAdminDistrictModel = admin;

            }
            return pObj2;
        }


        public Province GetProvinceDetailsforPostalCountingAPI(List<DataRow> rows)
        {
            var pObj2 = new Province();
            var admin = new List<AdminDistrict>();

            if (rows.Count > 0)
            {
                foreach (var row in rows)
                {
                    pObj2.province_name_en = row[0].ToString();

                    var district = new AdminDistrict()
                    {
                        admin_dis_name_en = row[1].ToString(),
                        ListofDistrictCentreModel = new List<DistrictCentre>() {new DistrictCentre() {dc_name_en = row[2].ToString(),
                        ListofCountingCentreModel = new List<CountingCentre>() { new CountingCentre() { cc_name_en = row[3].ToString(),
                         vote_type = row[4].ToString() } } } }
                    };

                    admin.Add(district);

                }

                pObj2.ListofAdminDistrictModel = admin;
            }

            return pObj2;
        }
    }
}
