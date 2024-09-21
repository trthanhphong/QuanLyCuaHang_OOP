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
    public class LuuTruLoaiSanPham : ILuuTruLoaiSanPham
    {
        public List<LoaiSanPham> DocDanhSachLoaiSanPham()
        {
            StreamReader file = new StreamReader("C:\\VB2\\loaisanpham.json");
            string jsonString = file.ReadToEnd();
            file.Close();

            var result = JsonConvert.DeserializeObject<List<LoaiSanPham>>(jsonString);
            return result;
        }

        public void LuuTruDanhSachLoaiSanPham(List<LoaiSanPham> l)
        {
            StreamWriter writer = new StreamWriter("C:\\VB2\\loaisanpham.json");
            string jsonString = JsonConvert.SerializeObject(l);
            writer.Write(jsonString);
            writer.Close();
        }

        public void LuuLoaiSanPham(LoaiSanPham sp)
        {
            var ds = DocDanhSachLoaiSanPham();
            ds.Add(sp);
            LuuTruDanhSachLoaiSanPham(ds);
        }

        public void SuaLoaiSanPham(LoaiSanPham spSua)
        {
            var ds = DocDanhSachLoaiSanPham();
            foreach (var sp in ds)
            {
                if (sp.MaLoaiSanPham == spSua.MaLoaiSanPham)
                {
                    sp.TenLoaiSanPham = spSua.TenLoaiSanPham;
                }
            }
            LuuTruDanhSachLoaiSanPham(ds);
        }

        public List<LoaiSanPham> TimKiem(string TuKhoa)
        {
            var dssp = DocDanhSachLoaiSanPham();
            var kq = new List<LoaiSanPham>();
            foreach (var sp in dssp)
            {
                if (sp.TenLoaiSanPham.Contains(TuKhoa))
                {
                    kq.Add(sp);
                }
            }
            return kq;
        }

        public LoaiSanPham DocLoaiSanPham(string masp)
        {
            var dssp = DocDanhSachLoaiSanPham();
            foreach (var sp in dssp)
            {
                if (sp.MaLoaiSanPham == masp)
                {
                    return sp;
                }
            }
            return null;
        }
    }

}
