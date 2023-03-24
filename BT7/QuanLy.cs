using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT7
{
    public class QuanLy
    {
        private List<NhanVienHanhChinh> dsNhanVien = new List<NhanVienHanhChinh>();
        private List<GiaoVien> dsGiaoVien = new List<GiaoVien>();

        public void InputNhanVien()
        {
            Console.Write("Hay nhap so luong nhan vien hanh chinh: ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine("Thong tin nhan vien {0}", i + 1);
                Console.Write("Ma so: ");
                string maSo = Console.ReadLine();

                Console.Write("Ho ten: ");
                string hoTen = Console.ReadLine();

                Console.Write("Gioi tinh: ");
                string gioiTinh = Console.ReadLine();

                Console.Write("So ngay cong: ");
                int soNgayCong = int.Parse(Console.ReadLine());

                Console.Write("Luong thang: ");
                int luongThang = int.Parse(Console.ReadLine());

                NhanVienHanhChinh nv = new NhanVienHanhChinh(maSo, hoTen, gioiTinh, soNgayCong, luongThang);
                dsNhanVien.Add(nv);
            }
        }
        public void InputGiaoVien()
        {
            Console.Write("So luong giao vien: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i<n; i++ )
            {
                Console.WriteLine("Nhap thong tin giao vien {0}", i + 1);

                Console.Write("Ma so: ");
                string maSo = Console.ReadLine();

                Console.Write("Ho ten: ");
                string hoTen = Console.ReadLine();

                Console.Write("Gioi tinh: ");
                string gioiTinh = Console.ReadLine();

                Console.Write("So tiet giang: ");
                int soTietGiang = int.Parse(Console.ReadLine());

                Console.Write("Thu lao tiet giang: ");
                int thuLaoTietGiang = int.Parse(Console.ReadLine());

                GiaoVien gv = new GiaoVien(maSo, hoTen, gioiTinh, soTietGiang, thuLaoTietGiang);
                dsGiaoVien.Add(gv);
            }
        }

        public void OutputBangLuong()
        {
            Console.WriteLine("Bang Luong can bo: ");
            

            Console.WriteLine("Nhan vien Hanh CHinh: ");
            Console.WriteLine("{0,-10} {1, -20} {2, -10}", "Ma So", "Ho Ten", "Luong");
            foreach (NhanVienHanhChinh nv in dsNhanVien)
            {
                int luong = nv.TinhLuong();
                Console.WriteLine("{0,-10} {1, -20} {2, -10}", nv.MaSo, nv.HoTen, luong);
            }


            Console.WriteLine("\nGiao vien: ");
            Console.WriteLine("{0,-10} {1, -20} {2, -10}", "Ma So", "Ho Ten", "Luong");

            foreach (GiaoVien gv in dsGiaoVien)
            {
                int luong = gv.TinhLuong();
                Console.WriteLine("{0,-10} {1, -20} {2, -10}", gv.MaSo, gv.HoTen, luong);
            }
        }
    }
}
