using AsmShare.Helpers;
using AsmShare.Models;
using AsmShare.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsmShare.Services
{
    public interface IKhachHang_Svc
    {
        
        List<KhachHang> GetKhachHangAll();
        KhachHang GetKhachHang(int id);
        KhachHang GetKhachHang(string email);
        Task<int> AddKhachHangAsync(KhachHang khachHang);
        int AddKhachHang(KhachHang khachHang);
        int EditKhachHang(int id, KhachHang khachHang);
        int KHEditKhachHang(int id, KhachHang khachHang);
        Task<KhachHang> LoginAsync(ViewWebLogin viewWebLogin);
        KhachHang Login(ViewWebLogin viewWebLogin);
        int DoiPass(ViewDoiPass viewDoiPass);


    }
    public class KhachHang_Svc : IKhachHang_Svc
    {
        protected DataContext _context;
        protected IMaHoaHelper _maHoaHelper;
        public KhachHang_Svc(DataContext context, IMaHoaHelper maHoaHelper)
        {
            _context = context;
            _maHoaHelper = maHoaHelper;
        }
        public int AddKhachHang(KhachHang khachHang)
        {
            int ret = 0;
            try
            {
                khachHang.KhachHang_PassWord = _maHoaHelper.Mahoa(khachHang.KhachHang_PassWord);
                khachHang.KhachHang_PassWord2 = khachHang.KhachHang_PassWord;
                _context.Add(khachHang);
                _context.SaveChanges();
                ret = khachHang.KhachHang_Id;

            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public Task<int> AddKhachHangAsync(KhachHang khachHang)
        {
            int ret = 0;
            try
            {
                
                khachHang.KhachHang_PassWord = _maHoaHelper.Mahoa(khachHang.KhachHang_PassWord);
                khachHang.KhachHang_PassWord2 = khachHang.KhachHang_PassWord;
                _context.AddAsync(khachHang);
                _context.SaveChanges();
                ret = khachHang.KhachHang_Id;
            }
            catch
            {
                ret = 0;
            }
            return Task.FromResult(ret);
        }

       

        public int EditKhachHang(int id, KhachHang khachHang)
        {
            int ret = 0;
            try
            {
                KhachHang _KhachHang = null;
                _KhachHang = _context.KhachHangs.Find(id);
                _KhachHang.KhachHang_Name = khachHang.KhachHang_Name;
                _KhachHang.KhachHang_NgaySinh = khachHang.KhachHang_NgaySinh;
                _KhachHang.KhachHang_Email = khachHang.KhachHang_Email;
                _KhachHang.KhachHang_Sdt = khachHang.KhachHang_Sdt;
                _KhachHang.KhachHang_Mota = khachHang.KhachHang_Mota;

                if (_KhachHang.KhachHang_PassWord != null)
                {
                    khachHang.KhachHang_PassWord = _maHoaHelper.Mahoa(khachHang.KhachHang_PassWord);
                    _KhachHang.KhachHang_PassWord = khachHang.KhachHang_PassWord;
                    _KhachHang.KhachHang_PassWord2 = khachHang.KhachHang_PassWord2;

                }

                _context.Update(_KhachHang);
                _context.SaveChanges();
                ret = _KhachHang.KhachHang_Id;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public KhachHang GetKhachHang(int id)
        {
            KhachHang khachHang = null;
            khachHang = _context.KhachHangs.Find(id);
            return khachHang;
        }

        public KhachHang GetKhachHang(string email)
        {
            KhachHang khachHang = null;
            khachHang = _context.KhachHangs.Where(o => o.KhachHang_Email == email ).FirstOrDefault(); ;
            return khachHang;
        }

        public List<KhachHang> GetKhachHangAll()
        {
            List<KhachHang> list = new List<KhachHang>();
            list = _context.KhachHangs.ToList();
            return list;
        }

        public int KHEditKhachHang(int id, KhachHang khachHang)
        {
            int ret = 0;
            try
            {
                KhachHang _KhachHang = null;
                _KhachHang = _context.KhachHangs.Find(id);
                _KhachHang.KhachHang_Name = khachHang.KhachHang_Name;
                _KhachHang.KhachHang_NgaySinh = khachHang.KhachHang_NgaySinh;
                _KhachHang.KhachHang_Email = khachHang.KhachHang_Email;
                _KhachHang.KhachHang_Sdt = khachHang.KhachHang_Sdt;
                _KhachHang.KhachHang_Mota = null;
                 _KhachHang.KhachHang_PassWord = khachHang.KhachHang_PassWord;
                _KhachHang.KhachHang_PassWord2 = khachHang.KhachHang_PassWord2;
                _context.Update(_KhachHang);
                _context.SaveChanges();
                ret = _KhachHang.KhachHang_Id;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

                                        public KhachHang Login(ViewWebLogin viewWebLogin)
                                        {
                                            var u = _context.KhachHangs.Where(p => p.KhachHang_Email.Equals(viewWebLogin.Email)
                                            && p.KhachHang_PassWord.Equals(_maHoaHelper.Mahoa(viewWebLogin.Password))).FirstOrDefault();
                                            return u;
                                        }

        public int DoiPass(ViewDoiPass viewDoiPass)
        {

             var u =_context.KhachHangs.Where(p=>p.KhachHang_Id.Equals(viewDoiPass.IdKhachHang)&&p.KhachHang_PassWord.Equals(_maHoaHelper.Mahoa(viewDoiPass.Password))).FirstOrDefault();
            if(u!= null)
            {              
                int ret = 0;
                try
                {
                    KhachHang _KhachHang = null;
                    _KhachHang = _context.KhachHangs.Find(u.KhachHang_Id);
                    _KhachHang.KhachHang_PassWord = _maHoaHelper.Mahoa(viewDoiPass.PasswordNew);
                    _KhachHang.KhachHang_PassWord2 = _maHoaHelper.Mahoa(viewDoiPass.PasswordNew);
                    _context.Update(_KhachHang);
                    _context.SaveChanges();
                    ret = _KhachHang.KhachHang_Id;
                }
                catch
                {
                    ret = 0;
                }
                return ret;
            }
            return 0;
            
        }

        public async Task<KhachHang> LoginAsync(ViewWebLogin viewWebLogin)
        {
            var u = await _context.KhachHangs.
                Where(p => p.KhachHang_Email.Equals(viewWebLogin.Email) && p.KhachHang_PassWord
                .Equals(_maHoaHelper.Mahoa(viewWebLogin.Password))).FirstOrDefaultAsync();
                  return u;
        }


    }
}
