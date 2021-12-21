using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Web;

namespace LTQL_1721050513.Models
{
    public class NTHSanPham513
    {
        [Key]
        [Display(Name = "Mã Nhà Cung Cấp")]
        public int MaSanPham { get; set; }
        [StringLength(50)]
        [Display(Name = "Tên Nhà Cung Cấp")]
        public string TenSanPham { get; set; }

        [Display(Name = "Mã Nhà cung cấp")]
        public int MaNhaCungCap { get; set; }
        [ForeignKey("MaNhaCungCap")]
        public virtual NhaCungCap513 NhaCungCap { get; set; }
    }
}