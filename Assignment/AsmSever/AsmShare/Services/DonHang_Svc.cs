using AsmShare.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsmShare.Services
{
    public interface IDonHang_Svc
    {
        List<DonHang> GetDonHangAll();
        List<DonHang> GetDonHangByKhachHang(int khachhangId);
        Task<List<DonHang>> GetDonHangByKhachHangAsync(int khachhangId);
        Task<DonHang> GetDonHangAsync(int id);
        DonHang GetDonHang(int id);
        Task<int> AddDonHangAsync(DonHang donHang);
        int AddDonHang(DonHang donHang);
        int EditDonHang(int id, DonHang donhang);

    }
    public class DonHang_Svc : IDonHang_Svc
    {
        protected DataContext _context;
        public DonHang_Svc(DataContext context)
        {
            _context = context;
        }

        public int AddDonHang(DonHang donHang)
        {
            int ret = 0;
            try
            {
                _context.Add(donHang);
                _context.SaveChanges();
                ret = donHang.DonHang_Id;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public async Task<int> AddDonHangAsync(DonHang donHang)
        {
            int ret = 0;
            try
            {
                _context.Add(donHang);
                await _context.SaveChangesAsync();
                //_context.SaveChanges();
                ret = donHang.DonHang_Id;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditDonHang(int id, DonHang donhang)
        {
            int ret = 0;
            try
            {

                _context.Update(donhang);
                _context.SaveChanges();
                ret = donhang.DonHang_Id;
            }
            catch(Exception ex)
            {
                ret = 0;
            }
            return ret;
        }

        public DonHang GetDonHang(int id)
        {
            DonHang donhang = null;
            donhang = _context.DonHangs.Where(x => x.DonHang_Id == id)
                .Include(x => x.KhachHang)
                .Include(x => x.ChiTietDonHangs).ThenInclude(y => y.MonAn)
                .FirstOrDefault();
            //product = _context.Products.Where(e=>e.Id==id).FirstOrDefault(); //cách tổng quát
            return donhang;
        }

        public List<DonHang> GetDonHangAll()
        {
            List<DonHang> list = new List<DonHang>();
            list = _context.DonHangs.OrderByDescending(x => x.NgayDat)
                .Include(x => x.KhachHang)
                .Include(x => x.ChiTietDonHangs).ToList();
            return list;
        }

        public async Task<DonHang> GetDonHangAsync(int id)
        {
            DonHang donhang = null;
            donhang = await _context.DonHangs.Where(x => x.DonHang_Id == id)
                .Include(x => x.KhachHang)
                .Include(x => x.ChiTietDonHangs).ThenInclude(y => y.MonAn)
                .FirstOrDefaultAsync();
            //product = _context.Products.Where(e=>e.Id==id).FirstOrDefault(); //cách tổng quát
            return donhang;
        }

        public List<DonHang> GetDonHangByKhachHang(int khachhangId)
        {
            List<DonHang> list = new List<DonHang>();
           
            list = _context.DonHangs.Where(x => x.KhachHang_Id == khachhangId).OrderByDescending(x => x.NgayDat)
                .Include(x => x.KhachHang)
                .Include(x => x.ChiTietDonHangs)
                .ToList();
            return list;
        }

        public async Task<List<DonHang>> GetDonHangByKhachHangAsync(int khachhangId)
        {
            List<DonHang> list = new List<DonHang>();
            list = await _context.DonHangs.Where(x => x.KhachHang_Id == khachhangId).OrderByDescending(x => x.NgayDat)
                .Include(x => x.KhachHang)
                .Include(x => x.ChiTietDonHangs).ThenInclude(y=>y.MonAn)
                .ToListAsync();
            return list;
                 
        }
    }
}
