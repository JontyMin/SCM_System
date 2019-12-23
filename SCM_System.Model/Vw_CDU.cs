using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_System.Model
{
   public class Vw_CDU
    {
        [Key]
        [StringLength(14)]
        public string CDID { get; set; }

        [StringLength(6)]
        public string DepotID { get; set; }

        public DateTime? CDDate { get; set; }

        public int? UserID { get; set; }

        [StringLength(1000)]
        public string CDDesc { get; set; }

        public int? CDState { get; set; }

        //[Key]
        //[StringLength(6)]
        //public string DepotID { get; set; }

        [StringLength(100)]
        public string DepotName { get; set; }

        [StringLength(100)]
        public string DepotMan { get; set; }

        [StringLength(100)]
        public string DepotTel { get; set; }

        [StringLength(200)]
        public string DepotAddress { get; set; }

        [StringLength(1000)]
        public string DepotDesc { get; set; }

        public int UsersID { get; set; }

        [StringLength(50)]
        public string UsersName { get; set; }

        [StringLength(20)]
        public string UserLoginName { get; set; }

        [StringLength(20)]
        public string UserLoginPwd { get; set; }

        [StringLength(50)]
        public string UUID { get; set; }
    }
}
