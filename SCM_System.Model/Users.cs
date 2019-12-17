namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users : BaseEntity
    {
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
