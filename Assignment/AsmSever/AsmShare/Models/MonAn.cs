
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsmShare.Models
{
    public enum Phanloai
    {
        [Display(Name = "Món_Chính")]
        MonChinh = 1,
        [Display(Name = "Món_Tráng_Miệng")]
        MonTrangMieng = 2,
        [Display(Name = "Nước")]
        Nuoc = 3,
    }
    public  class MonAn
    {
        [Key]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu")]
        public int MonAn_Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu")]
        [Column(TypeName = "nvarchar(250)")]
        public string MonAn_Name { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu")]
        public float MonAn_Gia { get; set; }
       
        public String MonAn_Image { get; set; }
       
        [Display(Name = "Phân loại")]
        [Required(ErrorMessage = "Bạn cần chọn phân loại."), Range(1, int.MaxValue, ErrorMessage = "Bạn cần chọn phân loại.")]
        public Phanloai MonAn_DanhMuc { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập dữ liệu")]
        [Column(TypeName = "nvarchar(250)")]
        public string MonAn_MoTa { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu")]
        public DateTime MonAn_NgayTao { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu")]
        [Column(TypeName = "nvarchar(250)")]
        public DateTime MonAn_NgaySua { get; set; }
        
        [Column(TypeName = "nvarchar(250)")]
        public string MonAn_GhiChu { get; set; }
        [Display(Name = "Đang phục vụ")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu")]
        public bool Trangthai { get; set; }
        public float VAT { get; set; }
        public bool IsDelete { get; set; }
        public ICollection<ChiTietDonHang> ChiTietDonHang { get; set; }
      //  public DanhMuc DanhMuc { get; set; }

    }
}
