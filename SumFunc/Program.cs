using System;
using System.Collections;
using System.Collections.Generic;

namespace SumFunc
{
    class Program
    {
        static Dictionary<int, bool> _memo = new Dictionary<int, bool>() {
            {0, true}
        };

        static Dictionary<int, List<int>> _memo2 = new Dictionary<int, List<int>>();

        static void Main(string[] args)
        {
            int[] a1 = { 5, 3, 4, 7 };
            int[] a2 = { 2, 3, 5 };
            int[] a3 = { 1, 4, 5 };
            int[] a4 = { 1, 2, 5, 25 };
            Console.Write(CanSum.canSum(7, a1) + ": ");
            PrintValues(BestSum.bestSum(7, a1));
            Console.Write(CanSum.canSum(8, a2) + ": ");
            PrintValues(BestSum.bestSum(8, a2));
            Console.Write(CanSum.canSum(8, a3) + ": ");
            PrintValues(BestSum.bestSum(8, a3));
            // Console.Write(CanSum.canSum(8, a3) + ": ");
            // PrintValues(BestSum.bestSum_memo(8, a3, _memo2));
            Console.Write(CanSum.canSum(100, a4) + ": ");
            PrintValues(BestSum.bestSum_memo(100, a4, _memo2));
        }

        public static void PrintValues(List<int> myList)
        {
            if (myList != null)
            {
                foreach (int obj in myList)
                {
                    Console.Write("   {0}", obj);
                }
            }
            Console.WriteLine();
        }
    }
}
