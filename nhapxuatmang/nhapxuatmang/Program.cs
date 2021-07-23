using System;

namespace nhapxuatmang
{
    class Program
    {
        static void nhapmang(int []a, int n) {
            for (int i = 0; i < n; i++) {
                Console.WriteLine("A[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void xuatmang(int[] a, int n) {
            for (int i = 0; i < n; i++) {
                Console.WriteLine("A[{0}] = {1}", i, a[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = new int[100];
            int n;
            Console.WriteLine("Nhap n = ");
            n = int.Parse(Console.ReadLine());
            nhapmang(a, n);
            xuatmang(a, n);
        }
    }
}
