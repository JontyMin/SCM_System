namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SplitDetail")]
    public partial class SplitDetail : BaseEntity
    {
        [Key]
        public int SDID { get; set; }

        [StringLength(14)]
        public string SplitID { get; set; }

        [StringLength(50)]
        public string ProID { get; set; }

        public int? SDAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SDPrice { get; set; }

        [StringLength(1000)]
        public string SDDesc { get; set; }
    }
}
