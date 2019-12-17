namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuotePrice")]
    public partial class QuotePrice : BaseEntity
    {
        [Key]
        [StringLength(14)]
        public string QPID { get; set; }

        [StringLength(14)]
        public string CusID { get; set; }

        public int? UserID { get; set; }

        public DateTime? QPDate { get; set; }

        public int? QPState { get; set; }

        [StringLength(1000)]
        public string QPDesc { get; set; }
    }
}
