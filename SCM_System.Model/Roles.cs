namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Roles : BaseEntity
    {
        [Key]
        public int RoleID { get; set; }

        [StringLength(100)]
        public string RoleName { get; set; }

        [StringLength(1000)]
        public string RoleDesc { get; set; }
    }
}
