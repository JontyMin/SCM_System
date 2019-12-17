namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaleDepot")]
    public partial class SaleDepot : BaseEntity
    {
        [Key]
        [StringLength(14)]
        public string SDID { get; set; }

        [StringLength(14)]
        public string CusID { get; set; }

        [StringLength(6)]
        public string DepotID { get; set; }

        public DateTime? SDDate { get; set; }

        public int? UserID { get; set; }

        public int? SDState { get; set; }

        [StringLength(1000)]
        public string SDDesc { get; set; }
    }
}
