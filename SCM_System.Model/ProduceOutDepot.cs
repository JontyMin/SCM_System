namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProduceOutDepot")]
    public partial class ProduceOutDepot : BaseEntity
    {
        [Key]
        [StringLength(14)]
        public string PODID { get; set; }

        [StringLength(6)]
        public string DepotID { get; set; }

        public DateTime? PODDate { get; set; }

        public int? UserID { get; set; }

        public int? PODState { get; set; }

        [StringLength(1000)]
        public string PODDesc { get; set; }
    }
}
