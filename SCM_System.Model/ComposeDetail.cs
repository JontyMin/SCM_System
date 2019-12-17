namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ComposeDetail")]
    public partial class ComposeDetail:BaseEntity
    {
        [Key]
        public int CDID { get; set; }

        [StringLength(14)]
        public string ComposeID { get; set; }

        [StringLength(50)]
        public string ProID { get; set; }

        public int? CDAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CDPrice { get; set; }

        [StringLength(1000)]
        public string CDDesc { get; set; }
    }
}
