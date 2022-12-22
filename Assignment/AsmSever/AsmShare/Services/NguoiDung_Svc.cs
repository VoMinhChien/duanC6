using AsmShare.Helpers;
using AsmShare.Models;
using AsmShare.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsmShare.Services
{
    public interface INguoiDung_Svc
    {
        List<NguoiDung> GetNguoidungAll();

        NguoiDung GetNguoidung(int id);

        int AddNguoidung(NguoiDung nguoidung);

        int EditNguoidung(int id, NguoiDung nguoidung);

        NguoiDung Login(ViewLogin viewLogin);
        int xoa(int id);
    }
    public class NguoiDung_Svc : INguoiDung_Svc
    {
        protected DataContext _context;
        protected IMaHoaHelper _mahoaHelper;
        public NguoiDung_Svc(DataContext context, IMaHoaHelper mahoaHelper)
        {
            _context = context;
            _mahoaHelper = mahoaHelper;
        }
        public int AddNguoidung(NguoiDung nguoidung)
        {
            int ret = 0;
            try
            {
                nguoidung.IsDelete = false;
                nguoidung.NguoiDung_PassWord = _mahoaHelper.Mahoa(nguoidung.NguoiDung_PassWord);
                nguoidung.NguoiDung_PassWord2 = nguoidung.NguoiDung_PassWord;


                _context.Add(nguoidung);
                _context.SaveChanges();
                ret = nguoidung.NguoiDung_Id;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditNguoidung(int id, NguoiDung nguoidung)
        {
            int ret = 0;
            try
            {
                nguoidung.IsDelete = false;
                NguoiDung _nguoidung = null;
                _nguoidung = _context.NguoiDungs.Find(id); //cách này chỉ dùng cho Khóa chính

                _nguoidung.NguoiDung_UserName = nguoidung.NguoiDung_UserName;
                _nguoidung.NguoiDung_Name = nguoidung.NguoiDung_Name;
                _nguoidung.Title = nguoidung.Title;
                _nguoidung.NguoiDung_NgaySinh = nguoidung.NguoiDung_NgaySinh;
                _nguoidung.NguoiDung_Email = nguoidung.NguoiDung_Email;
               
                _nguoidung.Locked = nguoidung.Locked;
                _nguoidung.NguoiDung_SoDienThoai = nguoidung.NguoiDung_SoDienThoai;
                if (nguoidung.NguoiDung_PassWord != null) // giữ nguyên mật khẩu cũ
                {
                    nguoidung.NguoiDung_PassWord = _mahoaHelper.Mahoa(nguoidung.NguoiDung_PassWord);
                    _nguoidung.NguoiDung_PassWord = nguoidung.NguoiDung_PassWord;
                    _nguoidung.NguoiDung_PassWord2 = nguoidung.NguoiDung_PassWord;
                }
                _context.Update(_nguoidung);
                _context.SaveChanges();
                ret = nguoidung.NguoiDung_Id;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public NguoiDung GetNguoidung(int id)
        {
            NguoiDung nguoidung = null;
            nguoidung = _context.NguoiDungs.Find(id); //cách này chỉ dùng cho Khóa chính
            //product = _context.Products.Where(e=>e.Id==id).FirstOrDefault(); //cách tổng quát
            return nguoidung;
        }

        public List<NguoiDung> GetNguoidungAll()
        {
            List<NguoiDung> list = new List<NguoiDung>();
            list = _context.NguoiDungs.Where(o=>o.IsDelete==false).ToList();
            return list;
        }

        public NguoiDung Login(ViewLogin viewLogin)
        {
            var a = _context.NguoiDungs.Where(a => a.NguoiDung_UserName == viewLogin.UserName).FirstOrDefault();
            var pas = _mahoaHelper.Mahoa(viewLogin.Password);
            var u = _context.NguoiDungs.Where(p => p.NguoiDung_UserName == viewLogin.UserName
               && p.NguoiDung_PassWord == pas).FirstOrDefault();
            return u;
        }

        public int xoa(int id)
        {

            var f = _context.NguoiDungs.Find(id);
            f.IsDelete = true;
            _context.Update(f);
            _context.SaveChanges();
            return id;
        }
    }
}
