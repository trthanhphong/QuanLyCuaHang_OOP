using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Microsoft.Exchange.WebServices.Data;
using DAL;
namespace Services
{
    public interface IXuLyLoaiSanPham
    {
        ServiceResult<bool> ThemLoaiSanPham(LoaiSanPham sp);
        ServiceResult<bool> SuaLoaiSanPham(LoaiSanPham sp);
        List<LoaiSanPham> TimKiem(string TuKhoa);
        ServiceResult<LoaiSanPham> DocLoaiSanPham(string msp);
    }

}
