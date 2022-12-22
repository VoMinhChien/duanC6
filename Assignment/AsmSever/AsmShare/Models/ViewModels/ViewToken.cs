using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsmShare.Models.ViewModels
{
    public class ViewToken
    {
        public string Token { get; set; }


        public int KhachHang_Id { get; set; }
        public string KhachHang_Name { get; set; }
        public string KhachHang_sdt { get; set; }
        public string KhachHang_Diachi { get; set; }
        public float KhachHang_DaVAT{ get; set; }
    }
}
