namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OtherInDepotDetail")]
    public partial class OtherInDepotDetail : BaseEntity
    {
        [Key]
        public int OIDDID { get; set; }

        [StringLength(50)]
        public string ProID { get; set; }

        [StringLength(14)]
        public string OIDID { get; set; }

        public int? OIDDAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OIDDPrice { get; set; }

        [StringLength(1000)]
        public string OIDDDesc { get; set; }
    }
}
