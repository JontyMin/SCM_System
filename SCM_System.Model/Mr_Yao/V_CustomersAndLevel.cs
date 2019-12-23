using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_System.Model.Mr_Yao
{
    public class V_CustomersAndLevel:BaseEntity
    {
        public string CusID { get; set; }

        public int? CLID { get; set; }

        public string CusName { get; set; }


        public string CusCompany { get; set; }
  
        public string CusMan { get; set; }

        public string CusDesc { get; set; }

        public string CLName { get; set; }

        public int? CLAgio { get; set; }
    }
}
