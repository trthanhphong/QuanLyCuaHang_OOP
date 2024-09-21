using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public interface ILuuTruSanPham
    {
        void LuuSanPham(SanPham t);
        List<SanPham> TimKiem(string TuKhoa);

        SanPham DocSanPham(string msp);
        void SuaSanPham(SanPham spSua);
    }
}
