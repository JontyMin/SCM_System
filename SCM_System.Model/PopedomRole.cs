namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PopedomRole")]
    public partial class PopedomRole : BaseEntity
    {
        [Key]
        public int PRID { get; set; }

        public int? RoleID { get; set; }

        public int? PopID { get; set; }
    }
}
