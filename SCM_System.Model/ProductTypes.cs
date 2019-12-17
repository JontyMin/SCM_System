namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductTypes : BaseEntity
    {
        [Key]
        public int PTID { get; set; }

        public int? PTParentID { get; set; }

        [StringLength(100)]
        public string PTName { get; set; }

        [StringLength(1000)]
        public string PTDes { get; set; }
    }
}
