namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProduceInDepotDeteil")]
    public partial class ProduceInDepotDeteil : BaseEntity
    {
        [Key]
        public int PIDDID { get; set; }

        [StringLength(50)]
        public string ProID { get; set; }

        [StringLength(14)]
        public string PIDID { get; set; }

        public int? PIDDAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PIDDPrice { get; set; }

        [StringLength(1000)]
        public string PIDDDesc { get; set; }
    }
}
