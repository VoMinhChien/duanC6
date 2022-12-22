using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsmShare.Models.ViewModels
{
    public class ViewCart
    {
        public MonAn sp { get; set; }

        public int SoLuong { get; set; }
    }
    public class Cart
    {
        public int KhanghangId { get; set; }
        public List<CartItem> ListViewCart { get; set; } = new List<CartItem>();
        public float Tongtien { get; set; }
        public string KhachhangName { get; set; }
        public string KhachHangSdt { get; set; }
        public string KhachHangDiachi { get; set; }
        public string KhachHangEmail { get; set; }
        public float VAT { get; set; }
        public float GiaTienDaVaT { get; set; }
        public bool Isdelete { get; set; }
    }

    public class CartItem
    {
        public MonAn MonAn { get; set; }
        public int Quantity { get; set; }
        public float Sotien { get; set; }
    }


}
