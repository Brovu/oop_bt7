using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT7
{
    class NhanVienHanhChinh : Generate
    {
 
        public int SoNgayCong { get; set; }
        public int LuongThang { get; set; }

        public NhanVienHanhChinh(string maSo, string hoTen, string gioiTinh, int soNgayCong, int luongThang) : base( maSo, hoTen, gioiTinh)
        {
            MaSo = maSo;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            SoNgayCong = soNgayCong;
            LuongThang = luongThang;
        }


        public int TinhLuong()
        {
            return SoNgayCong * LuongThang / 26;
        }
    }
}
