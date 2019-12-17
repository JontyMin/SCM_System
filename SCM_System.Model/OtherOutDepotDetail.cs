namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OtherOutDepotDetail")]
    public partial class OtherOutDepotDetail : BaseEntity
    {
        [Key]
        public int OODDID { get; set; }

        [StringLength(14)]
        public string OODID { get; set; }

        [StringLength(50)]
        public string ProID { get; set; }

        public int? OODDAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OODDPrice { get; set; }

        [StringLength(1000)]
        public string OODDDesc { get; set; }
    }
}
