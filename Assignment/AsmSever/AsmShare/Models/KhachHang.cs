using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsmShare.Models
{
    public class KhachHang
    {
        [Key]
        public int KhachHang_Id { get; set; }
        [StringLength(150)]
        [Required(ErrorMessage = "Bạn cần nhập họ tên.")]
        public string KhachHang_Name { get; set; }
        [Required(ErrorMessage = "Bạn cần nhập Ngày Sinh.")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? KhachHang_NgaySinh { get; set; }
        [Required(ErrorMessage = "Bạn cần nhập số điện thoại."), Display(Name = "Số phone")]
        [Column(TypeName = "varchar(15)"), MaxLength(15)]
        [RegularExpression(@"^\(?([0-9]{3})[-. ]?([0-9]{4})[-. ]?([0-9]{3})$", ErrorMessage = "Số điện thoại không phù hợp.")]
        public string KhachHang_Sdt { get; set; }
        [Required(ErrorMessage = "Bạn cần nhập email."), Display(Name = "Email")]
        [Column(TypeName = "varchar(50)"), MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Email không phù hợp.")]
        public string KhachHang_Email { set; get; }
        [Column(TypeName = "varchar(50)"), MaxLength(50)]
        [Required(ErrorMessage = "Bạn cần nhập mật khẩu.")]
        public string KhachHang_PassWord { set; get; }
        [Column(TypeName = "varchar(50)"), MaxLength(50)]
        [DataType(DataType.Password)]
        [Compare("KhachHang_PassWord", ErrorMessage = "Mật khẩu gõ lại không khớp.")]
        public string KhachHang_PassWord2 { get; set; }
        [StringLength(250)]
        public string KhachHang_Mota { set; get; }
        public ICollection<DonHang> DonHang { get; set; }
    }
}
