namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaleDepotDetail")]
    public partial class SaleDepotDetail : BaseEntity
    {
        [Key]
        public int SDDID { get; set; }

        [StringLength(14)]
        public string SDID { get; set; }

        [StringLength(50)]
        public string ProID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SDDPrice { get; set; }

        public int? SDDDiscount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SDDDisPrice { get; set; }

        [StringLength(1000)]
        public string SDDDesc { get; set; }

        public int? SDDAmount { get; set; }
    }
}
