using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        public static int BinSearch(int[] a, int num)
        {
            int left = 0, right = a.Length - 1, middle;
            while (left <= right)
            {
                middle = (left + right) / 2;
                if (a[middle] == num)
                    return middle;
                else
                    if (num < a[middle])
                    right = middle - 1;
                else
                    left = middle + 1;
            }
            return -1;
        }
        public static int RBinSearch(int[] a, int num, int left, int right)
        {
            if (left > right)
                return -1;
            int middle = (left +right) / 2;
            if (a[middle] == num)
                return middle;
            if (num < a[middle])
                return RBinSearch(a, num, left, middle - 1);
            return RBinSearch(a, num, middle + 1, right);
        }
        public static int WBinSearch(int[] a, int num)
        {
            return RBinSearch(a, num, 0, a.Length - 1);
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            Console.WriteLine(BinSearch(a, 4));
            Console.WriteLine(WBinSearch(a, 8));
        }
    }
}
