using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsmShare.Models
{
    public enum TrangthaiDonhang
    {
        [Display(Name = "Mới đặt")]
        Moidat = 1,
        [Display(Name = "Đang giao")]
        Danggiao = 2,
        [Display(Name = "Đã giao")]
        Dagiao = 3
    }
    public class DonHang
    {
        [Key]
        public int DonHang_Id { get; set; }
        [ForeignKey("KhachHang")]   
        public int KhachHang_Id { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string KhachHang_Name { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string KhachHang_Email { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string KhachHang_SoDienThoai { get; set; }
        [Column(TypeName = "nvarchar(255)")]
        public string KhachHang_DiaChi { get; set; }
        public float GiaTienChuaVAT { get; set; }
        public float GiaTienDaVAT { get; set; }
        public float VAT { get; set; }
      
        public DateTime NgayDat { get; set; }
        public TrangthaiDonhang HoaDon_TrangThai { get; set; }
        [Column(TypeName = "bit")]
        public bool IsDelete { get; set; }
        public KhachHang KhachHang { get; set; }
        public List<ChiTietDonHang> ChiTietDonHangs { get; set; }
        
    
    
    }
}
