namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProduceOutDepotDetail")]
    public partial class ProduceOutDepotDetail : BaseEntity
    {
        [Key]
        public int PODDID { get; set; }

        [StringLength(14)]
        public string PODID { get; set; }

        [StringLength(50)]
        public string ProID { get; set; }

        public int? PODDAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PODDPrice { get; set; }

        [StringLength(1000)]
        public string PODDDesc { get; set; }
    }
}
