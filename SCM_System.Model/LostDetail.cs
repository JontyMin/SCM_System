namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LostDetail")]
    public partial class LostDetail : BaseEntity
    {
        [Key]
        public int LDID { get; set; }

        [StringLength(14)]
        public string LostID { get; set; }

        [StringLength(50)]
        public string ProID { get; set; }

        public int? LDAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LDPrice { get; set; }

        [StringLength(1000)]
        public string LDDesc { get; set; }
    }
}
