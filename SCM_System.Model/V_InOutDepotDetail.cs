namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_InOutDepotDetail : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IODDID { get; set; }

        public int? IODID { get; set; }

        [StringLength(50)]
        public string ProID { get; set; }

        public int? IODDAmount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IODDPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IODDOutPrice { get; set; }

        [StringLength(100)]
        public string ProName { get; set; }

        [StringLength(100)]
        public string PTName { get; set; }

        [StringLength(50)]
        public string PUName { get; set; }

        [StringLength(50)]
        public string PCName { get; set; }

        [StringLength(50)]
        public string PSName { get; set; }

        [StringLength(6)]
        public string DepotID { get; set; }

        [StringLength(100)]
        public string DepotName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IODDMoney { get; set; }
    }
}
