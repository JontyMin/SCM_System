namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductSpec")]
    public partial class ProductSpec : BaseEntity
    {
        [Key]
        public int PSID { get; set; }

        [StringLength(50)]
        public string PSName { get; set; }
    }
}
