namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StockInDepot")]
    public partial class StockInDepot : BaseEntity
    {
        [Key]
        [StringLength(14)]
        public string SIDID { get; set; }

        [StringLength(12)]
        public string PPID { get; set; }

        [StringLength(6)]
        public string DepotID { get; set; }

        [StringLength(14)]
        public string StockID { get; set; }

        public DateTime? SIDDate { get; set; }

        [StringLength(100)]
        public string SIDDeliver { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SIDFreight { get; set; }

        public int? SIDUser { get; set; }

        public int? SIDData { get; set; }

        [StringLength(1000)]
        public string SIDDesc { get; set; }
    }
}
