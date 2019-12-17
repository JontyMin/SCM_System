namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductUnit")]
    public partial class ProductUnit : BaseEntity
    {
        [Key]
        public int PUID { get; set; }

        [StringLength(50)]
        public string PUName { get; set; }
    }
}
