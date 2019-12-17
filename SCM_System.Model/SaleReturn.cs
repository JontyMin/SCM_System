namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaleReturn")]
    public partial class SaleReturn : BaseEntity
    {
        [Key]
        [StringLength(14)]
        public string SRID { get; set; }

        [StringLength(14)]
        public string CusID { get; set; }

        [StringLength(6)]
        public string DepotID { get; set; }

        public DateTime? SRDate { get; set; }

        public int? UserID { get; set; }

        public int? SRState { get; set; }

        [StringLength(1000)]
        public string SRDesc { get; set; }
    }
}
