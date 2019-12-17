namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuotePriceDetail")]
    public partial class QuotePriceDetail : BaseEntity
    {
        [Key]
        public int QPDID { get; set; }

        [StringLength(14)]
        public string QPID { get; set; }

        [StringLength(50)]
        public string ProID { get; set; }

        public int? QPDAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QPDPrice { get; set; }

        public int? QPDDiscont { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QPDDisPrice { get; set; }

        [StringLength(1000)]
        public string QPDDesc { get; set; }
    }
}
