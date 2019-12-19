namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DevolveDetail")]
    public partial class DevolveDetail : BaseEntity
    {
        [Key]
        public int DevDID { get; set; }

        [StringLength(14)]
        public string DevID { get; set; }

        [StringLength(50)]
        public string ProID { get; set; }

        public int? DevDAmount { get; set; }

        [StringLength(1000)]
        public string DevDDesc { get; set; }
        //ssss
    }
}
