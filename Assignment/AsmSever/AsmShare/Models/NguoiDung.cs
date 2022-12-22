using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AsmShare.Models
{
    public enum Role
    {
        [EnumMember(Value = "Quản trị")]
        [Display(Name = "Admin")]
        Admin,
        [EnumMember(Value = "User")]
        [Display(Name = "Người dùng")]
        User,
    }
    public class NguoiDung
    {
        [Key]
        public int NguoiDung_Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Tài khoản")]
        [Required(ErrorMessage = "Bạn cần nhập tài khoản.")]
        public string NguoiDung_UserName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu")]
        public string NguoiDung_Name { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string NguoiDung_Email { get; set; }

        [Display(Name = "Chức danh")]
        [Column(TypeName = "nvarchar(100)")]
        public Role Title { get; set; }
        

        [Display(Name = "Khóa")]
        public bool Locked { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu")]
        [Column(TypeName = "nvarchar(250)")]
        public string NguoiDung_PassWord { get; set; }
        [Column(TypeName = "varchar(50)"), MaxLength(50)]
        [DataType(DataType.Password)]
        [Compare("NguoiDung_PassWord", ErrorMessage = "Mật khẩu gõ lại không khớp.")]
        public string NguoiDung_PassWord2 { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu")]
        [Column(TypeName = "nvarchar(250)")]
        
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? NguoiDung_NgaySinh { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập số điện thoại.")]
        [Column(TypeName = "varchar(15)"), MaxLength(15)]
        [RegularExpression(@"^\(?([0-9]{3})[-. ]?([0-9]{4})[-. ]?([0-9]{3})$", ErrorMessage = "Số điện thoại không phù hợp.")]
        public string NguoiDung_SoDienThoai { get; set; }
        public bool IsDelete { get; set; }
       // [Display(Name = "Vai trò")]
       // public Role Role { get; set; }
      
        
       
    
    }
}
