using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT11_Queue
{
    class Program
    {
        //Ham kiem tra so hoan hao
        public static bool KiemTraSoHoanHao(int n)
        {
            int TongUocSo = 0;
            for(int i=1;i<n;i++)
            {
                if (n % i == 0) TongUocSo += i;
            }
            return (TongUocSo == n);
        }
        static void Main(string[] args)
        {
            //Khai bao bien
            Queue<int> queue = new Queue<int>();
            int sopt = 0;

            Console.WriteLine("Chuong trinh minh hoa hang doi");
            Console.Write("Nhap so phan tu: ");
            sopt = int.Parse(Console.ReadLine());
            for(int i=1;i<=sopt;i++)
            {
                Console.Write("Phan tu thu {0}: ", i);
                int value = int.Parse(Console.ReadLine());
                queue.Enqueue(value);
            }
            int Dem = 0;
            Console.WriteLine("\nCac so hoan hao co trong danh sach: ");
            while(queue.Count>0)
            {
                int value = queue.Dequeue();
                if(KiemTraSoHoanHao(value))
                {
                    Console.Write("{0}\t", value);
                    Dem++;
                }
            }
            Console.WriteLine("\nCo {0} so hoan hao trong danh sach", Dem);
            Console.ReadLine();
        }
    }
}
