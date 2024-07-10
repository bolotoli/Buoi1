using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        public static void MergeSort(int[] arr)
        {
            MergeSort(arr, 0, arr.Length - 1);
        }

        // Hàm MergeSort sử dụng đệ quy
        private static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2; // Tìm chỉ số phân đoạn

                MergeSort(arr, left, mid); // Đệ quy phần bên trái
                MergeSort(arr, mid + 1, right); // Đệ quy phần bên phải

                Merge(arr, left, mid, right); // Hợp nhất hai mảng đã sắp xếp
            }
        }

        // Hàm Merge để hợp nhất hai mảng đã sắp xếp
        private static void Merge(int[] arr, int left, int mid, int right)
        {
            // Độ dài của hai mảng con cần hợp nhất
            int n1 = mid - left + 1;
            int n2 = right - mid;

            // Tạo mảng tạm thời để lưu các mảng con
            int[] L = new int[n1];
            int[] R = new int[n2];

            // Sao chép dữ liệu vào mảng tạm thời L[] và R[]
            for (int i = 0; i < n1; ++i)
                L[i] = arr[left + i];
            for (int j = 0; j < n2; ++j)
                R[j] = arr[mid + 1 + j];

            // Hợp nhất các mảng tạm thời vào mảng arr[]

            // Chỉ số ban đầu của hai mảng con
            int iL = 0, iR = 0;

            // Chỉ số ban đầu của mảng hợp nhất
            int k = left;
            while (iL < n1 && iR < n2)
            {
                if (L[iL] <= R[iR])
                {
                    arr[k] = L[iL];
                    iL++;
                }
                else
                {
                    arr[k] = R[iR];
                    iR++;
                }
                k++;
            }

            // Sao chép các phần tử còn lại của L[], nếu có
            while (iL < n1)
            {
                arr[k] = L[iL];
                iL++;
                k++;
            }

            // Sao chép các phần tử còn lại của R[], nếu có
            while (iR < n2)
            {
                arr[k] = R[iR];
                iR++;
                k++;
            }
        }

        // Hàm để in mảng
        public static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        // Hàm Main để thử nghiệm
        public static void Main()
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Mảng ban đầu:");
            PrintArray(arr);

            MergeSort(arr);
            Console.WriteLine("\nMảng đã sắp xếp bằng Merge Sort:");
            PrintArray(arr);

            // Để chương trình không tự đóng lại ngay sau khi chạy xong,
            // bạn có thể yêu cầu người dùng nhấn phím bất kỳ để thoát.
            Console.WriteLine("\nNhấn phím bất kỳ để thoát.");
            Console.ReadKey(); // Đọc ký tự từ bàn phím (để chương trình không tự đóng lại)
        }
    }
} 
