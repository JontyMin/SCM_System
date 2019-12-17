namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaleReturnDetail")]
    public partial class SaleReturnDetail : BaseEntity
    {
        [Key]
        public int SRDID { get; set; }

        [StringLength(14)]
        public string SRID { get; set; }

        public int? ProID { get; set; }

        public int? SRDAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SRDPrice { get; set; }

        [StringLength(1000)]
        public string SRDDesc { get; set; }
    }
}
