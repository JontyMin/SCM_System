namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Compose")]
    public partial class Compose:BaseEntity
    {
        [StringLength(14)]
        public string ComposeID { get; set; }

        [StringLength(6)]
        public string DepotID { get; set; }

        [StringLength(50)]
        public string ProID { get; set; }

        public int? UserID { get; set; }

        public DateTime? ComposeDate { get; set; }

        [StringLength(1000)]
        public string ComposeDesc { get; set; }

        public int? ComposeState { get; set; }

        public int? ComposeAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ComposePrice { get; set; }
    }
}
