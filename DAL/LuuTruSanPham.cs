using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;
using Newtonsoft.Json;

namespace DAL
{
    public class LuuTruSanPham : ILuuTruSanPham
    {
        public List<SanPham> DocDanhSachSanPham()
        {
            StreamReader file = new StreamReader("C:\\VB2\\sanpham.json");
            string jsonString = file.ReadToEnd();
            file.Close();

            var result = JsonConvert.DeserializeObject<List<SanPham>>(jsonString);
            return result;
        }

        public void LuuTruDanhSachSanPham(List<SanPham> l)
        {
            StreamWriter writer = new StreamWriter("C:\\VB2\\sanpham.json");
            string jsonString = JsonConvert.SerializeObject(l);
            writer.Write(jsonString);
            writer.Close();
        }

        public void LuuSanPham(SanPham sp)
        {
            var ds = DocDanhSachSanPham();
            ds.Add(sp);
            LuuTruDanhSachSanPham(ds);
        }

        public void SuaSanPham(SanPham spSua)
        {
            var ds = DocDanhSachSanPham();
            foreach (var sp in ds)
            {
                if (sp.MaSanPham == spSua.MaSanPham)
                {
                    sp.TenSanPham = spSua.TenSanPham;
                    sp.Gia = spSua.Gia;
                }
            }
            LuuTruDanhSachSanPham(ds);
        }

        public List<SanPham> TimKiem(string TuKhoa)
        {
            var dssp = DocDanhSachSanPham();
            var kq = new List<SanPham>();
            foreach (var sp in dssp)
            {
                if(sp.TenSanPham.Contains(TuKhoa))
                {
                    kq.Add(sp);
                }
            }
            return kq;
        }

        public SanPham DocSanPham(string masp)
        {
            var dssp = DocDanhSachSanPham();
            foreach (var sp in dssp)
            {
                if (sp.MaSanPham== masp)
                {
                    return sp;
                }
            }
            return null;
        }
    }
}
