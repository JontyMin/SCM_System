namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Stocks : BaseEntity
    {
        [Key]
        [StringLength(14)]
        public string StockID { get; set; }

        [StringLength(12)]
        public string PPID { get; set; }

        public DateTime? StockDate { get; set; }

        public DateTime? StockInDate { get; set; }

        public int? StockUser { get; set; }

        public int? StockState { get; set; }

        [StringLength(1000)]
        public string StockDesc { get; set; }
    }
}
