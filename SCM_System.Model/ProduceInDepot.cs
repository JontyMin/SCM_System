namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProduceInDepot")]
    public partial class ProduceInDepot : BaseEntity
    {
        [Key]
        [StringLength(14)]
        public string PIDID { get; set; }

        [StringLength(6)]
        public string DepotID { get; set; }

        public DateTime? PIDDate { get; set; }

        public int? PIDUser { get; set; }

        public int? PIDState { get; set; }

        [StringLength(1000)]
        public string PDIDesc { get; set; }
    }
}
