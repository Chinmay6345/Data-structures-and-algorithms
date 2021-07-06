using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceiling_on_left_side_in_an_array
{

    public static class AppHelper
    {
        public static void printCeiling(Int32[] arr, Int32 n)
        {
            SortedSet<Int32> s = new SortedSet<Int32>();
            s.Add(arr[0]);
            for (int i = 1; i < n; i++)
            {
                var ceil = s.LastOrDefault(k => k > arr[i]);
                if (ceil > s.ElementAt(0))
                    Console.Write(ceil);
                else
                    Console.Write("-1" + " ");
                s.Add(arr[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 8, 30, 15, 25, 12 };
            int n = arr.Length;

            AppHelper.printCeiling(arr, n);
            Console.ReadLine();
        }
    }
}
