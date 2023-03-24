using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLy quanLyCanBo = new QuanLy();
            quanLyCanBo.InputNhanVien();
            quanLyCanBo.InputGiaoVien();
            quanLyCanBo.OutputBangLuong();

            Console.ReadKey();
        }
    }
}
