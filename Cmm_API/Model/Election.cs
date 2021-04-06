using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cmm_API.Model
{
    public class Election
    {
        public string election_id { get; set; }

        public string election_name_en { get; set; }

        public string election_name_si { get; set; }

        public string election_name_ta { get; set; }

        public string election_template_name { get; set; }

        public string active_status { get; set; }

        public string itteration_id { get; set; }
    }
}
