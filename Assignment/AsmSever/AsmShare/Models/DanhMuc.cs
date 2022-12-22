using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace AsmShare.Models
{
    public  class DanhMuc
    {
        [Key]
        public int DanhMuc_Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập dữ liệu")]
        [Column(TypeName = "nvarchar(255)")]
        public string DanhMuc_Name { get; set; }
        public ICollection<MonAn> MonAn { get; set; }
    }
}
