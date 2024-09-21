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
    public interface IXuLySanPham
    {
        ServiceResult<bool> ThemSanPham(SanPham sp);
        ServiceResult<bool> SuaSanPham(SanPham sp);
        List<SanPham> TimKiem(string TuKhoa);
        ServiceResult<SanPham> DocSanPham(string msp);
    }
}
