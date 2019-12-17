namespace SCM_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductLend")]
    public partial class ProductLend : BaseEntity

    {
    [Key] [StringLength(14)] public string PPID { get; set; }

    [StringLength(100)] public string PPName { get; set; }

    [StringLength(200)] public string PPCompany { get; set; }

    [StringLength(50)] public string PPMan { get; set; }

    [StringLength(100)] public string PPTel { get; set; }

    [StringLength(300)] public string PPAddress { get; set; }

    [StringLength(100)] public string PPFax { get; set; }

    [StringLength(100)] public string PPEmail { get; set; }

    [StringLength(100)] public string PPUrl { get; set; }

    [StringLength(200)] public string PPBank { get; set; }

    [StringLength(100)] public string PPGoods { get; set; }

    [StringLength(2000)] public string PPDesc { get; set; }
    }
}
