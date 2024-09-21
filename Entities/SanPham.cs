using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int Gia { get; set; }
        public SanPham()
        {

        }

        public SanPham(string ma, string ten, int gia)
        {
            if (string.IsNullOrWhiteSpace(ma) ||
               string.IsNullOrWhiteSpace(ten) ||
               gia < 0)
            {
                throw new Exception("San pham khong hop le");
            }

            MaSanPham = ma;
            TenSanPham = ten;
            Gia = gia;
        }

    }
}
