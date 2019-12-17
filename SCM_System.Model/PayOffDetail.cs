namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PayOffDetail")]
    public partial class PayOffDetail : BaseEntity
    {
        [Key]
        public int PODID { get; set; }

        [StringLength(14)]
        public string POID { get; set; }

        [StringLength(50)]
        public string ProID { get; set; }

        public int? PODAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PODPrice { get; set; }

        [StringLength(1000)]
        public string PODDesc { get; set; }
    }
}
