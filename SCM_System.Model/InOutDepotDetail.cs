namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InOutDepotDetail")]
    public partial class InOutDepotDetail : BaseEntity
    {
        [Key]
        public int IODDID { get; set; }

        public int? IODID { get; set; }

        [StringLength(50)]
        public string ProID { get; set; }

        public int? IODDAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IODDPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IODDOutPrice { get; set; }
    }
}
