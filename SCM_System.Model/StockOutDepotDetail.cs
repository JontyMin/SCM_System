namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StockOutDepotDetail")]
    public partial class StockOutDepotDetail : BaseEntity
    {
        [Key]
        public int SRDDID { get; set; }

        public int ProID { get; set; }

        [Required]
        [StringLength(14)]
        public string SRDID { get; set; }

        public int SIDDAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SIDDPrice { get; set; }

        [Required]
        [StringLength(1000)]
        public string SIDDDesc { get; set; }
    }
}
