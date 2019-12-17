namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StockInDepotDetail")]
    public partial class StockInDepotDetail : BaseEntity
    {
        [Key]
        public int SIDDID { get; set; }

        [StringLength(50)]
        public string ProID { get; set; }

        [StringLength(14)]
        public string SIDID { get; set; }

        public int? SIDDAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SIDDPrice { get; set; }

        [StringLength(1000)]
        public string SIDDDesc { get; set; }
    }
}
