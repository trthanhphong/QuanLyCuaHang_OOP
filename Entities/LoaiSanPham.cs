using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class LoaiSanPham
    {
        public string MaLoaiSanPham { get; set; }
        public string TenLoaiSanPham { get; set; }
        public LoaiSanPham()
        {

        }

        public LoaiSanPham(string ma, string ten)
        {
            if (string.IsNullOrWhiteSpace(ma) ||
               string.IsNullOrWhiteSpace(ten) )
            {
                throw new Exception("San pham khong hop le");
            }

            MaLoaiSanPham = ma;
            TenLoaiSanPham = ten;
        }
    }
}
