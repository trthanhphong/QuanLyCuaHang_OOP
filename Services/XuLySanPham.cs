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
    public class XuLySanPham : IXuLySanPham
    {
        private ILuuTruSanPham luuTruSanPham;
        public XuLySanPham()
        {
            luuTruSanPham = new LuuTruSanPham();
        }
        public ServiceResult<bool> ThemSanPham(SanPham sp)
        {
            try
            {
                luuTruSanPham.LuuSanPham(sp);
                return new ServiceResult<bool>(true, true, string.Empty);
            }

            catch (Exception ex)
            {
                return new ServiceResult<bool>(true, false, ex.Message);
            }

        }

        public ServiceResult<bool> SuaSanPham(SanPham sp)
        {
            try
            {
                luuTruSanPham.SuaSanPham(sp);
                return new ServiceResult<bool>(true, true, string.Empty);
            }

            catch (Exception ex)
            {
                return new ServiceResult<bool>(true, false, ex.Message);
            }

        }

        public ServiceResult<SanPham> DocSanPham(string msp)
        {
            try
            {
                var sp = luuTruSanPham.DocSanPham(msp);
                if(sp != null)
                {
                    return new ServiceResult<SanPham>(true, sp, string.Empty);
                }
                else
                {
                    return new ServiceResult<SanPham>(false, null, "San pham khong ton tai");
                }
                
            }

            catch (Exception ex)
            {
                return new ServiceResult<SanPham>(false, null, ex.Message);
            }

        }

        public List<SanPham> TimKiem(string TuKhoa)
        {
            if(TuKhoa == null)
            {
                TuKhoa = string.Empty;
            }
            return luuTruSanPham.TimKiem(TuKhoa);
        }
    }
}
