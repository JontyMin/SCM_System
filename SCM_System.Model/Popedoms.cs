namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Popedoms : BaseEntity
    {
        [Key]
        public int PopID { get; set; }

        [StringLength(100)]
        public string PopName { get; set; }

        public int? PopParentID { get; set; }

        public bool? PopIsMenu { get; set; }

        [StringLength(200)]
        public string PopValue { get; set; }

        [StringLength(1000)]
        public string PopDesc { get; set; }
    }
}
