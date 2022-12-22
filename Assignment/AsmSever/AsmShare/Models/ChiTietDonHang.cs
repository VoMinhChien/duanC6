using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsmShare.Models
{
    public class ChiTietDonHang
    {
        [Key]
        public int ChiTietDonHang_Id { get; set; }
        [ForeignKey("DonHang")]
        public int DonHang_Id { get; set; }
        [ForeignKey("MonAn")]
        public int MonAn_Id { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        [Required(ErrorMessage ="Vui lòng nhập dữ liệu")]
        public string MonAn_Name { get; set; }
        [Required,Range(0,int.MaxValue,ErrorMessage ="Bạn Cần Nhập Số Lượng")]
        public int MonAn_SoLuong { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu")]
        [Column(TypeName = "nvarchar(255)")]
        public string MonAn_Image { get; set; }
        [Required, Range(0, float.MaxValue, ErrorMessage = "Bạn Cần Nhập Thành Tiền")]
        public float MonAn_Gia { get; set; }
        public int VAT { get; set; }
        public bool IsDelete { get; set; }
        public DonHang DonHang { get; set; }
        public MonAn MonAn { get; set; }

    }
}
