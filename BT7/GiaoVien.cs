using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT7
{
    class GiaoVien : Generate
    {
        public int SoTietGiang { get; set; }
        public int ThuLaoTietGiang { get; set; }
        public GiaoVien(string maSo, string hoTen, string gioiTinh, int soTietGiang, int thuLaoTietGiang) : base(maSo, hoTen, gioiTinh)
        {
            MaSo= maSo;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            SoTietGiang= soTietGiang;
            ThuLaoTietGiang = thuLaoTietGiang;
        }

        public int TinhLuong()
        {
            return SoTietGiang * ThuLaoTietGiang;
        }
    }
}
