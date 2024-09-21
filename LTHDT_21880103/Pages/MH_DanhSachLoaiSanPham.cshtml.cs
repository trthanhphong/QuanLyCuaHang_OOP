using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace LTHDT_21880103.Pages
{
    public class MH_DanhSachLoaiSanPhamModel : PageModel
    {
        [BindProperty]
        public string TuKhoa { get; set; }
        public List<LoaiSanPham> DanhSachLoaiSanPham;

        private IXuLyLoaiSanPham xuLyLoaiSanPham;
        public void OnGet()
        {
            DanhSachLoaiSanPham = xuLyLoaiSanPham.TimKiem(String.Empty);
        }

        public void OnPost()
        {
            DanhSachLoaiSanPham = xuLyLoaiSanPham.TimKiem(TuKhoa);
        }

        public MH_DanhSachLoaiSanPhamModel()
        {
            xuLyLoaiSanPham = new XuLyLoaiSanPham();
            DanhSachLoaiSanPham = new List<LoaiSanPham>();
        }
    }
}
