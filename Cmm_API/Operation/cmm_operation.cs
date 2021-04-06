using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Cmm_API.Operation
{
    public class cmm_operation
    {
        private IConfiguration config;

        public cmm_operation(IConfiguration config1)
        {
            config = config1;
        }

        //private SqlConnection Connection()
        //{
        //    SqlConnection con = new SqlConnection(config.GetConnectionString("ConnectionString"));
        //    con.Open();
        //    return con;
        //}

        private MySqlConnection Connection()
        {
            MySqlConnection con = new MySqlConnection(config.GetConnectionString("ConnectionString"));
            con.Open();
            return con;
        }

        public object GetAll(string tblname)
        {
            DataTable dtbl = new DataTable();
            string query1 = "SELECT * FROM " + tblname;
            MySqlDataAdapter da = new MySqlDataAdapter(query1, this.Connection());
            da.Fill(dtbl);
            return dtbl;
        }

        
        public object GetHierarchy()
        {
            DataTable dtbl = new DataTable();
            string query = "SELECT Election.election_name_en, itteration.itteration_name, Province.province_name_en, AdminDistrict.admin_dis_name_en," +
                " ElectoralDistrict.ed_name_en, PollingDivision.pdiv_name_en , PollingDistrict.pd_num , PollingStation.ps_name_en , CountingCentre.cc_name, DistrictCentre.dc_name_en FROM " +
                " Election INNER JOIN itteration ON Election.itteration_id = itteration.itteration_id " +
                " INNER JOIN Province ON  itteration.itteration_id = Province.itteration_id " +
                " INNER JOIN  AdminDistrict ON Province.province_id = AdminDistrict.province_id " +
                " INNER JOIN ElectoralDistrict ON AdminDistrict.ed_id = ElectoralDistrict.ed_id " +
                " INNER JOIN PollingDivision ON ElectoralDistrict.ed_id = PollingDivision.ed_id " +
                " INNER JOIN PollingDistrict ON  PollingDivision.pdiv_id = PollingDistrict.pdiv_id" +
                " INNER JOIN PollingStation ON  PollingDistrict.pd_id = PollingStation.pd_id " + "" +
                " INNER JOIN CountingCentre ON  PollingStation.cc_id = CountingCentre.cc_id " +
                " INNER JOIN DistrictCentre ON CountingCentre.dc_id = DistrictCentre.dc_id";


            MySqlDataAdapter da = new MySqlDataAdapter(query, this.Connection());
            da.Fill(dtbl);
            return dtbl;
        }

        public object GetElectionDetailsAPI()
        {
            DataTable dtbl = new DataTable();
            string query = " SELECT Election.election_name_en FROM election ";

            MySqlDataAdapter da = new MySqlDataAdapter(query, this.Connection());
            da.Fill(dtbl);
            return dtbl;
        }

        public object GetActiveElectionDetailsAPI()
        {
            DataTable dtbl = new DataTable();
            string query = " SELECT Election.election_name_en, Election.election_template_name FROM election WHERE active_status= 'Yes' ";

            MySqlDataAdapter da = new MySqlDataAdapter(query, this.Connection());
            da.Fill(dtbl);
            return dtbl;
        }


        public object GetPollingStationsDatasetAPI()
        {
            DataTable dtbl = new DataTable();
            string query = " SELECT Province.province_name_en, AdminDistrict.admin_dis_name_en, PollingDivision.pdiv_name_en," + 
                           " PollingDistrict.pd_num, PollingStation.ps_name_en, PollingStation.registered_normal_voters, " + 
                           " PollingStation.registered_postal_voters, PollingStation.registered_displaced_voters, " + 
                           " PollingStation.registered_quarantine_voters " +
                           " FROM Province INNER JOIN AdminDistrict ON Province.province_id = AdminDistrict.province_id "+
                           " INNER JOIN ElectoralDistrict ON AdminDistrict.ed_id = ElectoralDistrict.ed_id " +
                           " INNER JOIN PollingDivision ON ElectoralDistrict.ed_id = PollingDivision.ed_id " +
                           " INNER JOIN PollingDistrict ON  PollingDivision.pdiv_id = PollingDistrict.pdiv_id" +
                           " INNER JOIN PollingStation ON  PollingDistrict.pd_id = PollingStation.pd_id ";

            MySqlDataAdapter da = new MySqlDataAdapter(query, this.Connection());
            da.Fill(dtbl);
            return dtbl;
        }

        public object GetCountingCentreDetails(int id)
        {
            DataTable dtbl = new DataTable();
            string query1 = " SELECT CountingCentre.cc_id, CountingCentre.cc_name FROM "+
                " Election INNER JOIN itteration ON Election.itteration_id = itteration.itteration_id " +
                " INNER JOIN Province ON  itteration.itteration_id = Province.itteration_id " +
                " INNER JOIN  AdminDistrict ON Province.province_id = AdminDistrict.province_id " +
                " INNER JOIN ElectoralDistrict ON AdminDistrict.ed_id = ElectoralDistrict.ed_id " +
                " INNER JOIN PollingDivision ON ElectoralDistrict.ed_id = PollingDivision.ed_id " +
                " INNER JOIN PollingDistrict ON  PollingDivision.pdiv_id = PollingDistrict.pdiv_id" +
                " INNER JOIN PollingStation ON  PollingDistrict.pd_id = PollingStation.pd_id " + "" +
                " INNER JOIN CountingCentre ON  PollingStation.cc_id = CountingCentre.cc_id " +
                " INNER JOIN DistrictCentre ON CountingCentre.dc_id = DistrictCentre.dc_id WHERE  CountingCentre.cc_id = '" + id + "'"; 
            MySqlDataAdapter da = new MySqlDataAdapter(query1, this.Connection());
            da.Fill(dtbl);
            return dtbl;
        }

        public object GetCountingDetails(int id)
       {
           DataTable dtbln = new DataTable();
            string query2 = "SELECT CountingCentre.cc_id, CountingCentre.cc_name  FROM CountingCentre";
            MySqlDataAdapter da1 = new MySqlDataAdapter(query2, this.Connection());
            da1.Fill(dtbln);
            return dtbln;

        }

        //public object GettestHierarchy()
        //{
        //    DataTable dtbl1 = new DataTable();
        //    string query2 = "SELECT Province.province_name_en, AdminDistrict.admin_dis_name_en, ElectoralDistrict.ed_name_en, PollingDivision.pdiv_name_en ," +
        //        " PollingDistrict.pd_num , PollingStation.ps_name_en , CountingCentre.cc_name, DistrictCentre.dc_id FROM " +
        //        " Province INNER JOIN  AdminDistrict ON Province.province_id = AdminDistrict.province_id " +
        //        " INNER JOIN ElectoralDistrict ON AdminDistrict.ed_id = ElectoralDistrict.ed_id " +
        //        " INNER JOIN PollingDivision ON ElectoralDistrict.ed_id = PollingDivision.ed_id " +
        //        " INNER JOIN PollingDistrict ON  PollingDivision.pdiv_id = PollingDistrict.pdiv_id" +
        //        " INNER JOIN PollingStation ON  PollingDistrict.pd_id = PollingStation.pd_id " + "" +
        //        " INNER JOIN CountingCentre ON  PollingStation.cc_id = CountingCentre.cc_id " +
        //        " INNER JOIN DistrictCentre ON CountingCentre.dc_id = DistrictCentre.dc_id";


        //    MySqlDataAdapter da1 = new MySqlDataAdapter(query2, this.Connection());
        //    da1.Fill(dtbl1);
        //    return dtbl1;

        //}

       // public object GetA()
       //{
       //    DataTable dtbl = new DataTable();
       //    string query1 = "SELECT ElectoralDistrict.ed_name_en, PollingDivision.pdiv_name_en , PollingDistrict.pd_num , PollingStation.ps_name_en FROM " +
       //         " ElectoralDistrict INNER JOIN PollingDivision ON ElectoralDistrict.ed_id = PollingDivision.ed_id " +
       //        " INNER JOIN PollingDistrict ON PollingDivision.pdiv_id = PollingDistrict.pdiv_id " +
       //         " INNER JOIN PollingStation ON  PollingDistrict.pd_id = PollingStation.pd_id";


       //    MySqlDataAdapter da = new MySqlDataAdapter(query1, this.Connection());
       //     da.Fill(dtbl);
       //     return dtbl;
       // }

    }

}
    

