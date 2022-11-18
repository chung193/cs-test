using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.data
{
    internal class KetNoi
    {
        public string ConString = "this is constring";
        public int[] temp = new int[]{1,2,3,4,5,6,7,8};
        public int[,] arr = new int[3, 4];

        public static int check(ref int b)
        {
            b = b * b;
            return b;
        }

        public static int checkout(out int b)
        {
            b = 10000;
            return b;
        }
        /// <summary>
        /// Tính tổng 2 số nguyên
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int TongHaiSo(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Sắp xếp mảng
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int[] SapXepMang(int[] a)
        {
            return a;
        }

        static double BinhPhuong(double num)
        {
            return num * num;
        }

        public static void TinhBinhPhuong(double a)
        {
            double kq = BinhPhuong(a);
            Console.WriteLine(kq);
        }

        public static string FullName(string ho, string ten, string tendem = "")
        {
            return ho + (tendem != "" ? " " + tendem : "") + " " + ten;
        }

    }
}
