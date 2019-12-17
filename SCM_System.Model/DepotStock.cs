namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DepotStock")]
    public partial class DepotStock:BaseEntity
    {
        [Key]
        public int DSID { get; set; }

        [StringLength(6)]
        public string DepotID { get; set; }

        [StringLength(50)]
        public string ProID { get; set; }

        public int? DSAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DSPrice { get; set; }
    }
}
