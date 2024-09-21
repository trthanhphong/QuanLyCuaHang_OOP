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
    public class MH_XoaSanPhamModel : PageModel
    {
        public string Chuoi { get; set; }
        [BindProperty]

        public string MaSP { get; set; }
        [BindProperty]

        public string TenSP { get; set; }
        [BindProperty]

        public int Gia { get; set; }

        private IXuLySanPham xuLySanPham;
        public void OnGet()
        {

        }

        public void OnPost()
        {
            try
            {
                SanPham sp = new SanPham(MaSP, TenSP, Gia);
                var kq = xuLySanPham.ThemSanPham(sp);
                if (kq.IsSuccess)
                {
                    Chuoi = " Luu tru thanh cong";
                }
                else
                {
                    Chuoi = kq.ErrorMessage;
                }
            }
            catch (Exception ex)
            {
                Chuoi = ex.Message;
            }
        }

        public MH_XoaSanPhamModel()
        {
            xuLySanPham = new XuLySanPham();
        }
    }
}
}
