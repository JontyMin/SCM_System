namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InOutDepot")]
    public partial class InOutDepot : BaseEntity
    {
        [Key]
        public int IODID { get; set; }

        [StringLength(6)]
        public string DepotID { get; set; }

        public int? IODType { get; set; }

        [StringLength(100)]
        public string IODNum { get; set; }

        public DateTime? IODDate { get; set; }

        public int? IODUser { get; set; }

        [StringLength(1000)]
        public string IODDesc { get; set; }

        [StringLength(14)]
        public string IODLend { get; set; }

        [StringLength(14)]
        public string IODCus { get; set; }
    }
}
