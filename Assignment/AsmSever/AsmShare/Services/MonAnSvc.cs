using AsmShare.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsmShare.Services
{
    public interface IMonAnSvc
    {
        Task<List<MonAn>> GetMonAnAllAsync();
        Task<List<MonAn>> GetMonAnAllAsync(Phanloai id);
        Task<List<MonAn>> GetMonAnAllAsync(string search);
        List<MonAn> GetMonAnAll();
   
        MonAn GetMonAn(int id);
        int AddMonAn(MonAn monan);
        int EditMonAn(int id, MonAn monan);
        int xoa(int id);
        Task<MonAn>GetDetailAsync(int id);
    }
    public class MonAnSvc : IMonAnSvc
    {
        protected DataContext _context;
        public MonAnSvc(DataContext context)
        {
            _context = context;
        }

        public int AddMonAn(MonAn monan)
        {
           
            int ret = 0;
            try
            {
               
                _context.Add(monan);
                _context.SaveChanges();
                ret = monan.MonAn_Id;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public async Task<MonAn> detailsmonan(int id)
        {
            var p = await _context.MonAns.SingleAsync(p => p.MonAn_Id == id);
            return p;
        }

        public int EditMonAn(int id, MonAn monan)
        {
            int ret = 0;
            try
            {
                _context.Update(monan);
                _context.SaveChanges();
                ret = monan.MonAn_Id;
            }
            catch
            {
                ret = 0;
            }

            return ret;
        }

        public async Task<MonAn> GetDetailAsync(int id)
        {
            MonAn monan = null;
            monan = await _context.MonAns.Where(x => x.MonAn_Id == id).FirstOrDefaultAsync();
            return monan;
        }

        public MonAn GetMonAn(int id)
        {
            MonAn monan = null;
            monan = _context.MonAns.Find(id);
            return monan;
        }

        public List<MonAn> GetMonAnAll()
        {
            List<MonAn> list = new List<MonAn>();
            list = _context.MonAns.Where(o => o.IsDelete == false).ToList();
            return list;
        }

        public async Task<List<MonAn>> GetMonAnAllAsync(Phanloai id)
        {
            List<MonAn> list = await _context.MonAns.Where(o=>o.MonAn_DanhMuc==id && o.IsDelete==false).ToListAsync();
               return list;
        }

        public async Task<List<MonAn>> GetMonAnAllAsync()
        {
            List<MonAn> list = await _context.MonAns.ToListAsync();
            return list;
        }

        public async Task<List<MonAn>> GetMonAnAllAsync(string search)
        {
            List<MonAn> list = await _context.MonAns.Where(o => o.IsDelete == false && o.MonAn_Name.Contains(search)).ToListAsync();
            return list;
        }

        public int xoa(int id)
        {
            var f = _context.MonAns.Find(id);
            
            f.IsDelete = true;
            _context.Update(f);
            _context.SaveChanges();
           return id;
        }







       




    }
}
