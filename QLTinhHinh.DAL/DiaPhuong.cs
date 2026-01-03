namespace QLTinhHinh.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiaPhuong")]
    public partial class DiaPhuong
    {
        [Key]
        [StringLength(3)]
        public string MaDP { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDP { get; set; }

        public int SoCaNhiemMoi { get; set; }

        public int MaTT { get; set; }

        public virtual TrangThai TrangThai { get; set; }
    }
}
