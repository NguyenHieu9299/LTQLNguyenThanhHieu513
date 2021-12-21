using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTQL_1721050513.Models
{
    public class NhaCungCap513
    {
        [Key]
        [Display(Name = "Mã Nhà Cung Cấp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaNhaCungCap { get; set; }
        [StringLength(50)]
        [Display(Name = "Tên Nhà Cung Cấp")]

        public string TenNhaCungCap { get; set; }

        public ICollection<NTHSanPham513> Sanphams { get; set; }
    }
}