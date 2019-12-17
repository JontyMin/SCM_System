namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerLevel")]
    public partial class CustomerLevel:BaseEntity
    {
        [Key]
        public int CLID { get; set; }

        [StringLength(100)]
        public string CLName { get; set; }

        public int? CLAgio { get; set; }
    }
}
