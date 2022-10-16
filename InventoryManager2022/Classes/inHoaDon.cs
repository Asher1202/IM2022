using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager2022.Classes
{
    public class inHoaDon
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderID { get; set; }

        public string customerID { get; set; }

        public double giatien { get; set; }

        public int quantity { get; set; }

        public string diachi { get; set; }
        public string MaNV { get; set; }
        public string hangmua { get; set; }
        public string phone { get; set; }

        public string loaihangmua { get; set; }

        public int staticid  { get; set; }
        public string date { get; set; }
    }
}
