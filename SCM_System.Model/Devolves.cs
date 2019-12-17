namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Devolves : BaseEntity
    {
        [Key]
        [StringLength(14)]
        public string DevID { get; set; }

        [StringLength(6)]
        public string DevOutID { get; set; }

        [StringLength(6)]
        public string DevInID { get; set; }

        public int? UserID { get; set; }

        public DateTime? DevDate { get; set; }

        [StringLength(1000)]
        public string DevDesc { get; set; }

        public int? DevState { get; set; }
    }
}
