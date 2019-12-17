namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Depots:BaseEntity
    {
        [Key]
        [StringLength(6)]
        public string DepotID { get; set; }

        [StringLength(100)]
        public string DepotName { get; set; }

        [StringLength(100)]
        public string DepotMan { get; set; }

        [StringLength(100)]
        public string DepotTel { get; set; }

        [StringLength(200)]
        public string DepotAddress { get; set; }

        [StringLength(1000)]
        public string DepotDesc { get; set; }
    }
}
