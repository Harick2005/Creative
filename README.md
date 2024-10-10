[Toán rời rạc.pptx](https://github.com/user-attachments/files/17330225/Toan.r.i.r.c.pptx)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        /*
        Câu 1: Cấu trúc dữ liệu để lưu trữ mặt hàng trong trường hợp này là danh sách liên kết (SortedList)
        Câu 2: Trong danh sách liên kết (Sorted List), mỗi nút (node) bao gồm hai thành phần: một giá trị và một tham chiếu đến nút tiếp theo trong danh sách. Điều này cho phép các nút trong danh sách được thêm, xóa và truy cập một cách linh hoạt. Tuy nhiên, vì không có cơ chế sắp xếp tự động như trong SortedList, việc tìm kiếm có thể không nhanh như trong các cấu trúc dữ liệu khác như mảng hoặc SortedList.
        Câu 3: Để cài đặt cấu trúc dữ liệu Sorted list, sử dụng class SortedList trong namepace
        using System .Collection.Genric;
        Cú pháp SortedList<int, khachHang> danhSachKH = new SortedList<int, khachHang>();
        */

        struct khachHang
        {
            public int maKhachHang;
            public string tenKhachHang;
            public string diaChi;
            public double doanhSo;
            public double duNo;
            public khachHang(int mkh, string tkh, string dc, double ds, double dn)
            {
                maKhachHang = mkh;
                tenKhachHang = tkh;
                diaChi = dc;
                doanhSo = ds;
                duNo = dn;
            }
            public void Nhap()
            {
                Console.Write("Ma khach hang: ");
                maKhachHang = int.Parse(Console.ReadLine());
                Console.Write("Ten khach hang: ");
                tenKhachHang = Console.ReadLine();
                Console.Write("Dia chi: ");
                diaChi = Console.ReadLine();
                Console.Write("Doanh so: ");
                doanhSo = double.Parse(Console.ReadLine());
                Console.Write("Du no: ");
                duNo = double.Parse(Console.ReadLine());
            }
            public void In()
            {
                Console.WriteLine("{0, -10} {1, -25} {2, -30} {3, -40} {4, -20}", maKhachHang, tenKhachHang, diaChi, doanhSo, duNo);
            }
            public string ToStringForFile()
            {
                return "{maKhachHang},{tenKhachHang},{diaChi},{doanhSo},{duNo}";
            }
        }

        static void Main(string[] args)
        {
            SortedList<int, khachHang> danhSachKH = new SortedList<int, khachHang>();

            while (true)
            {
                Console.WriteLine("\n====================================");
                Console.WriteLine("1. Them so luong khach hang");
                Console.WriteLine("2. Khách hang co doanh so ");
                Console.WriteLine("3.In ra danh sach khach hang");
                Console.WriteLine("4. Xoa khach hang");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("\n====================================");
                Console.Write("Nhap lua chon cua ban: ");
                
                int luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        Console.Write("Nhap so luong khach hang: ");
                        int soLuong = int.Parse(Console.ReadLine());
                        for (int i = 0; i < soLuong; i++)
                        {
                            khachHang kh = new khachHang();
                            Console.WriteLine("Nhap thong tin cho khach hang {0}:", i + 1);
                            kh.Nhap();
                            danhSachKH[kh.maKhachHang] = kh;
                        }
                        Console.WriteLine("Da them khach hang thanh cong!");
                        break;
                    case 2:
                        Console.Write("Nhap doanh so: ");
                        double doanhSoInput = double.Parse(Console.ReadLine());
                        Console.WriteLine("Danh sach khach hang co doanh so lon hon {0}:", doanhSoInput);
                        Console.WriteLine("{0, -10} {1, -25} {2, -30} {3, -40} {4, -20}", "Ma KH", "Ten KH", "Dia Chi", "Doanh So", "Du No");
                        foreach (var khach in danhSachKH.Values.Where(kh => kh.doanhSo > doanhSoInput).OrderBy(kh => kh.duNo))
                        {
                            khach.In();
                        }
                        break;

                    case 3:
                        Console.WriteLine("Danh sach khach hang:");
                        Console.WriteLine("{0, -10} {1, -25} {2, -30} {3, -40} {4, -20}", "Ma KH", "Ten KH", "Dia Chi", "Doanh So", "Du No");
                        foreach (var khach in danhSachKH.Values.OrderBy(kh => kh.duNo))
                        {
                            khach.In();
                        }
                        break;
                    case 4:
                        Console.Write("Nhap ma khach hang muon xoa: ");
                        int maKHCanXoa = int.Parse(Console.ReadLine());
                        if (danhSachKH.Remove(maKHCanXoa))
                        {
                            Console.WriteLine("Da xoa khach hang co ma: {0}", maKHCanXoa);
                        }
                        else
                        {
                            Console.WriteLine("Khach hang khong ton tai!");
                        }
                        break;
                    case 0:
                        return;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }
        }

    }
}

          
