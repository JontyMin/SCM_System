namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Splits : BaseEntity
    {
        [Key]
        [StringLength(14)]
        public string SplitID { get; set; }

        [StringLength(6)]
        public string DepotID { get; set; }

        [StringLength(50)]
        public string ProID { get; set; }

        public int? UserID { get; set; }

        public DateTime? SplitDate { get; set; }

        [StringLength(1000)]
        public string SplitDesc { get; set; }

        public int? SplitState { get; set; }

        public int? SplitAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SplitPrice { get; set; }
    }
}
