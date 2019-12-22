using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_System.Model.Mr_Yao
{
    public class V_VProductsAndDepotStock:BaseEntity
    {
        public string ProID { get; set; }
        public int? PTID { get; set; }
        public string ProName { get; set; }
        public string PTName { get; set; }
        public decimal? ProInPrice { get; set; }

        public decimal? ProPrice { get; set; }

        public int ProCount { get; set; }
    }
}
