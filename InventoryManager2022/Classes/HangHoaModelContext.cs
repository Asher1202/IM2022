using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager2022.Classes
{
    public class HangHoaModelContext: DbContext
    {

        public HangHoaModelContext() : base("name=con") { }
        public DbSet<NhapHangHoa> Emplist { get; set; }
        public DbSet<NhanVienInfo> nhanVienInfos { get; set; }
        public DbSet<inHoaDon> inHoaDonInfos { get; set; }
    }
}
