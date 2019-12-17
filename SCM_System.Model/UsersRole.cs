namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsersRole")]
    public partial class UsersRole : BaseEntity
    {
        [Key]
        public int URID { get; set; }

        public int? UsersID { get; set; }

        public int? RoleID { get; set; }
    }
}
