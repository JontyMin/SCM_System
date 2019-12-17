namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckDepot")]
    public partial class CheckDepot:BaseEntity
    {
        [Key]
        [StringLength(14)]
        public string CDID { get; set; }

        [StringLength(6)]
        public string DepotID { get; set; }

        public DateTime? CDDate { get; set; }

        public int? UserID { get; set; }

        [StringLength(1000)]
        public string CDDesc { get; set; }

        public int? CDState { get; set; }
    }
}
