namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products : BaseEntity
    {
        [Key]
        [StringLength(50)]
        public string ProID { get; set; }

        public int? PTID { get; set; }

        public int? PUID { get; set; }

        public int? PCID { get; set; }

        public int? PSID { get; set; }

        [StringLength(100)]
        public string ProName { get; set; }

        [StringLength(100)]
        public string ProJP { get; set; }

        [StringLength(100)]
        public string ProTM { get; set; }

        [StringLength(200)]
        public string ProWorkShop { get; set; }

        public int? ProMax { get; set; }

        public int? ProMin { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ProInPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ProPrice { get; set; }

        [StringLength(2000)]
        public string ProDesc { get; set; }

        [StringLength(6)]
        public string DepotID { get; set; }
    }
}
