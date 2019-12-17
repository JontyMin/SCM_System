namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customers:BaseEntity
    {
        [Key]
        [StringLength(14)]
        public string CusID { get; set; }

        public int? CLID { get; set; }

        [StringLength(100)]
        public string CusName { get; set; }

        [StringLength(200)]
        public string CusCompany { get; set; }

        [StringLength(50)]
        public string CusMan { get; set; }

        [StringLength(2000)]
        public string CusDesc { get; set; }
    }
}
