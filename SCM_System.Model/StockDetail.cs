namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StockDetail")]
    public partial class StockDetail : BaseEntity
    {
        [Key]
        public int SDetailID { get; set; }

        [StringLength(50)]
        public string ProID { get; set; }

        [StringLength(14)]
        public string StockID { get; set; }

        public int? SDetailAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SDetailPrice { get; set; }

        public int? SDetailDepAmount { get; set; }

        [StringLength(1000)]
        public string SDetailDesc { get; set; }
    }
}
