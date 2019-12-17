namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductColor")]
    public partial class ProductColor : BaseEntity
    {
        [Key]
        public int PCID { get; set; }

        [StringLength(50)]
        public string PCName { get; set; }
    }
}
