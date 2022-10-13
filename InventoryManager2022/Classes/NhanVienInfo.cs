using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager2022.Classes
{
    public class NhanVienInfo
    {
        public int id { get; set; }
        [Key]
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string ChucVu { get; set; }

        public string NgaySinh { get; set; }

        [Phone]
        public string SoDienThoai { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }
    }
}
