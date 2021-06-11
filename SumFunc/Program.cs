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

        static Dictionary<int, ArrayList> _memo2 = new Dictionary<int, ArrayList>() {
            {0, new ArrayList()}
        };

        static void Main(string[] args)
        {
            int[] a1 = { 2, 3 };
            int[] a2 = { 5, 3, 4, 7 };
            int[] a3 = { 2, 4 };
            int[] a4 = { 2, 3, 5 };
            int[] a5 = { 7, 14 };
            Console.Write(CanSum.canSum(7, a1) + ": "); 
            PrintValues(HowSum.howSum(7, a1));
            Console.Write(CanSum.canSum(7, a2) + ": "); 
            PrintValues(HowSum.howSum(7, a2));
            Console.Write(CanSum.canSum(7, a3) + ": "); 
            PrintValues(HowSum.howSum(7, a3));
            Console.Write(CanSum.canSum(8, a4) + ": "); 
            PrintValues(HowSum.howSum(8, a4));
            Console.Write(CanSum.canSum_memo(300, a5, _memo) + ": "); 
            PrintValues(HowSum.howSum_memo(300, a5, _memo2));
        }

        public static void PrintValues(ArrayList myList)
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
