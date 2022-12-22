using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsmShare.Models.ViewModels
{
    public class ViewDoiPass
    {
        [Required]
        public int IdKhachHang { get; set; }

        [Required]
        public string Password { get; set; }
        [Required]
        public string PasswordNew { get; set; }

       
    }
}
