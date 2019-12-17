namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Losts : BaseEntity
    {
        [Key]
        [StringLength(14)]
        public string LostID { get; set; }

        [StringLength(6)]
        public string DepotID { get; set; }

        public DateTime? LostDate { get; set; }

        public int? UserID { get; set; }

        [StringLength(1000)]
        public string LostDesc { get; set; }

        public int? LostState { get; set; }
    }
}
