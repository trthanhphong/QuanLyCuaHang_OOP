using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using Microsoft.Exchange.WebServices.Data;

namespace Services
{
    public class XuLyLoaiSanPham : IXuLyLoaiSanPham
    {
        private ILuuTruLoaiSanPham luuTruLoaiSanPham;
        public XuLyLoaiSanPham()
        {
            luuTruLoaiSanPham = new LuuTruLoaiSanPham();
        }
        public ServiceResult<bool> ThemLoaiSanPham(LoaiSanPham sp)
        {
            try
            {
                luuTruLoaiSanPham.LuuLoaiSanPham(sp);
                return new ServiceResult<bool>(true, true, string.Empty);
            }

            catch (Exception ex)
            {
                return new ServiceResult<bool>(true, false, ex.Message);
            }

        }

        public ServiceResult<bool> SuaLoaiSanPham(SanPham sp)
        {
            try
            {
                luuTruLoaiSanPham.SuaLoaiSanPham(sp);
                return new ServiceResult<bool>(true, true, string.Empty);
            }

            catch (Exception ex)
            {
                return new ServiceResult<bool>(true, false, ex.Message);
            }

        }

        public ServiceResult<LoaiSanPham> DocLoaiSanPham(string msp)
        {
            try
            {
                var lsp = luuTruLoaiSanPham.DocLoaiSanPham(msp);
                if (lsp != null)
                {
                    return new ServiceResult<LoaiSanPham>(true, lsp, string.Empty);
                }
                else
                {
                    return new ServiceResult<LoaiSanPham>(false, null, "San pham khong ton tai");
                }

            }

            catch (Exception ex)
            {
                return new ServiceResult<LoaiSanPham>(false, null, ex.Message);
            }

        }

        public List<LoaiSanPham> TimKiem(string TuKhoa)
        {
            if (TuKhoa == null)
            {
                TuKhoa = string.Empty;
            }
            return luuTruLoaiSanPham.TimKiem(TuKhoa);
        }
    }
}
