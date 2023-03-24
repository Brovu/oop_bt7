using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT7
{
    public class Generate
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }

        public string GioiTinh { get; set; }

        public Generate(string maSo, string hoTen, string gioiTinh)
        {
            MaSo = maSo;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
        }

    }
}
