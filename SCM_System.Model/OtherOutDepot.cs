namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OtherOutDepot")]
    public partial class OtherOutDepot : BaseEntity
    {
        [Key]
        [StringLength(14)]
        public string OODID { get; set; }

        [StringLength(6)]
        public string DepotID { get; set; }

        public DateTime? OODDate { get; set; }

        public int? UserID { get; set; }

        public int? OODState { get; set; }

        [StringLength(1000)]
        public string OODDesc { get; set; }
    }
}
