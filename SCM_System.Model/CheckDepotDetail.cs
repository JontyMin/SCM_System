namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckDepotDetail")]
    public partial class CheckDepotDetail:BaseEntity
    {
        [Key]
        public int CDDID { get; set; }

        [StringLength(14)]
        public string CDID { get; set; }

        [StringLength(50)]
        public string ProID { get; set; }

        public int? CDDAmount1 { get; set; }

        public int? DevAmount2 { get; set; }

        [StringLength(1000)]
        public string CDDDesc { get; set; }
    }
}
