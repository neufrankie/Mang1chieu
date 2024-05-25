using System;

namespace Mang1Chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai báo kích thước của mảng
            const int ARRAY_SIZE = 5;

            // Khởi tạo mảng với kích thước đã cho
            int[] arr = new int[ARRAY_SIZE];

            // Nhập các phần tử của mảng từ người dùng
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                Console.Write("Nhap vao phan tu thu " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Hiển thị vài phần tử của mảng
                Console.WriteLine(numbers[0]);
                Console.WriteLine(numbers[2]);
                Console.WriteLine(numbers[3]);
            // Tính tổng các phần tử của mảng
            int sum = 0;
            foreach (int element in arr)
            {
                sum += element;
            }

            // Hiển thị tổng các phần tử của mảng
            Console.WriteLine("Tong cac phan tu cua mang la: " + sum);
        }
    }
}
