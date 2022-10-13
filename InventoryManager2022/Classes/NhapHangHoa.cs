using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager2022
{
    public class NhapHangHoa
    {
        

        public int id { get; set; }
        [Key]
        public string TenHang {get; set; }  
        public string SoLuongNhap { get; set; }
        public string NhaCungCap { get; set; }

        public string LoaiHangHoa { get; set; }

        public string SoTien { get; set; }
        public string SoTienBan { get; set; }

    }
}
