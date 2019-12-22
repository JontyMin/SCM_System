using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_System.Model.Mr_Yao
{
    public class V_CusAndCusOrderAndClv:BaseEntity
    {
        public int CODID { get; set; }
        public string COID { get; set; }

        public string CusID { get; set; }

        public string CusName { get; set; }

        public string CLName { get; set; }

        public decimal? CODCount { get; set; }

        public int? CODDiscont { get; set; }


    }
}
