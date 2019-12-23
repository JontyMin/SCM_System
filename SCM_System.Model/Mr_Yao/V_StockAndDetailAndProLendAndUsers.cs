using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_System.Model.Mr_Yao
{
    public class V_StockAndDetailAndProLendAndUsers:BaseEntity
    {
        public int SDetailID { get; set; }

        public string StockID { get; set; }
        public string PPID { get; set; }
        public string PPCompany { get; set; }

        public string UsersName { get; set; }

        public DateTime? StockDate { get; set; }

        public DateTime? StockInDate { get; set; }

        public decimal? StockCount { get; set; }
    }
}
