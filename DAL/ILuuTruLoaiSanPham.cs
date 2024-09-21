using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public interface ILuuTruLoaiSanPham
    {
        void LuuLoaiSanPham(LoaiSanPham t);
        List<LoaiSanPham> TimKiem(string TuKhoa);

        LoaiSanPham DocLoaiSanPham(string msp);
        void SuaLoaiSanPham(LoaiSanPham spSua);
    }

}
