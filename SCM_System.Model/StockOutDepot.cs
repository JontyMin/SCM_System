namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StockOutDepot")]
    public partial class StockOutDepot : BaseEntity
    {
        [Key]
        [StringLength(14)]
        public string SRDID { get; set; }

        [Required]
        [StringLength(12)]
        public string PPID { get; set; }

        [Required]
        [StringLength(14)]
        public string StockID { get; set; }

        [Required]
        [StringLength(6)]
        public string DepotID { get; set; }

        public DateTime SRDDate { get; set; }

        public int SIDUser { get; set; }

        public int SIDData { get; set; }

        [Required]
        [StringLength(1000)]
        public string SIDDesc { get; set; }
    }
}
