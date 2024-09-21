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
    public class MH_SuaSanPhamModel : PageModel
    {
        public string Chuoi { get; set; }
        [BindProperty (SupportsGet = true)]

        public string MaSP { get; set; }
        [BindProperty]

        public string TenSP { get; set; }
        [BindProperty]

        public int Gia { get; set; }

        private IXuLySanPham xuLySanPham;
        public SanPham SanPham;

        public void OnGet()
        {
            if(string.IsNullOrEmpty(MaSP))
            {
                Chuoi = " Ma san pham khong hop le";
            }
            else
            {
                var kq = xuLySanPham.DocSanPham(MaSP);
                if(kq.IsSuccess)
                {
                    SanPham = kq.Data;
                }
                else
                {
                    SanPham = null;
                    Chuoi = kq.ErrorMessage;
                }
            }

        }

        public void OnPost()
        {
            try
            {
                SanPham sp = new SanPham(MaSP, TenSP, Gia);
                var kq = xuLySanPham.SuaSanPham(sp);
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

        public MH_SuaSanPhamModel()
        {
            xuLySanPham = new XuLySanPham();
        }
    }

}
