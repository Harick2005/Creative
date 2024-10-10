using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT14_Stack
{
    class Program
    {
        //Ham kiem tra bieu thuc dau ngoac co hop le hay khoong
        public static bool KiemTraBieuThuc(string bt)
        {
            Stack<char> stack = new Stack<char>();
            foreach(char c in bt)
            {
                if (c != ')' && c != ']' && c != '}')
                    stack.Push(c);
                else if ((c == ')' && stack.Pop()!='(') || (c == ']' && stack.Pop()!='[') || (c == '}' && stack.Pop()!='{'))
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh minh hoa Stack kiem tra bieu thuc dau ngoac");
            Console.Write("Nhap chuoi bieu thuc: ");
            string bieuthuc = Console.ReadLine();
            if (KiemTraBieuThuc(bieuthuc))
                Console.WriteLine("Bieu thuc hop le!");
            else
                Console.WriteLine("Bieu thuc khong hop le!!");
            Console.ReadLine();
        }
    }
}
