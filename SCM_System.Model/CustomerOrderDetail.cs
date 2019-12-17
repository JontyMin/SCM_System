namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerOrderDetail")]
    public partial class CustomerOrderDetail:BaseEntity
    {
        [Key]
        public int CODID { get; set; }

        [StringLength(14)]
        public string COID { get; set; }

        [StringLength(50)]
        public string ProID { get; set; }

        public int? CODAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CODPrice { get; set; }

        public int? CODDiscont { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CODDisPrice { get; set; }

        public int? CODSale { get; set; }

        [StringLength(1000)]
        public string CODDesc { get; set; }
    }
}
