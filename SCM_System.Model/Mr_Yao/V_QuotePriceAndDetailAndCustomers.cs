using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_System.Model.Mr_Yao
{
    public class V_QuotePriceAndDetailAndCustomers:BaseEntity
    {
        public int QPDID { get; set; }
        public string QPID { get; set; }
        public string  CusID { get; set; }

        public string CusName { get; set; }
        public int? QPDDiscont { get; set; }

        public decimal? QPDCount { get; set; }
    }
}
