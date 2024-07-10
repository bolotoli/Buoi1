using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTong
{
    class Program
    {
        static void Main()
        {
            // Khởi tạo mảng a với các số nguyên
            int[] a = { 1, 2, 3, 4, 5 };

            // Biến để lưu tổng
            int sum = 0;

            // Duyệt qua từng phần tử trong mảng và tính tổng
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            // In ra tổng của các phần tử trong mảng
            Console.WriteLine("Tổng các phần tử trong mảng là: " + sum);


            Console.WriteLine("Nhấn phím bất kỳ để thoát.");
            Console.ReadKey();

        }
    }
}