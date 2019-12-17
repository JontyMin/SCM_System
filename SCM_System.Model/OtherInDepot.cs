namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OtherInDepot")]
    public partial class OtherInDepot : BaseEntity
    {
        [Key]
        [StringLength(14)]
        public string OIDID { get; set; }

        [StringLength(6)]
        public string DepotID { get; set; }

        public DateTime? OIDDate { get; set; }

        public int? OIDUser { get; set; }

        public int? OIDState { get; set; }

        [StringLength(1000)]
        public string OIDDesc { get; set; }
    }
}
