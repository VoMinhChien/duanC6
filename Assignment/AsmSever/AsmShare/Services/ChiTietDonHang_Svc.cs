using AsmShare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsmShare.Services
{
    public interface IChiTietDonHang_Svc
    {
        int AddChiTietDonHangSvc(ChiTietDonHang chiTietDonHang);
    }
    public class ChiTietDonHang_Svc : IChiTietDonHang_Svc
    {
        protected DataContext _context;
        public ChiTietDonHang_Svc(DataContext context)
        {
            _context = context;
        }

        public int AddChiTietDonHangSvc(ChiTietDonHang chiTietDonHang)
        {
            int ret = 0;
            try
            {
                _context.Add(chiTietDonHang);
                _context.SaveChanges();
                ret = chiTietDonHang.ChiTietDonHang_Id;
            }
            catch
            {
                ret=0;
            }
            return ret;
        }
    }
}
