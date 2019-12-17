namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerOrder")]
    public partial class CustomerOrder:BaseEntity
    {
        [Key]
        [StringLength(14)]
        public string COID { get; set; }

        [StringLength(14)]
        public string CusID { get; set; }

        public DateTime? CODate { get; set; }

        public DateTime? CORefDate { get; set; }

        public int? UserID { get; set; }

        public int? COState { get; set; }

        [StringLength(1000)]
        public string CODesc { get; set; }
    }
}
