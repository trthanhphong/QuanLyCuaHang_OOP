using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LTHDT_21880103.Pages
{
    public class MH_DanhSachSanPhamModel : PageModel
    {
        [BindProperty]
        public string TuKhoa { get; set; }
        public List<SanPham> DanhSachSanPham;

        private IXuLySanPham xuLySanPham;
        public void OnGet()
        {
            DanhSachSanPham = xuLySanPham.TimKiem(String.Empty);
        }

        public void OnPost()
        {
            DanhSachSanPham = xuLySanPham.TimKiem(TuKhoa);
        }

        public MH_DanhSachSanPhamModel()
        {
            xuLySanPham = new XuLySanPham();
            DanhSachSanPham = new List<SanPham>();
        }
    }
}
