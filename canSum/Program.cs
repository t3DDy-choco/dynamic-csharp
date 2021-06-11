using System;

namespace canSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 2, 3 };
            int[] a2 = { 5, 3, 4, 7 };
            int[] a3 = { 2, 4 };
            int[] a4 = { 2, 3, 5 };
            int[] a5 = { 7, 14 };
            Console.WriteLine(canSum(7, a1));
            Console.WriteLine(canSum(7, a2));
            Console.WriteLine(canSum(7, a3));
            Console.WriteLine(canSum(8, a4));
            Console.WriteLine(canSum(300, a5));
        }

        static bool canSum(int targetSum, int[] set)
        {
            if (targetSum == 0) return true;
            if (targetSum < 0) return false;
            foreach (int num in set)
            {
                int remainder = targetSum - num;
                if (canSum(remainder, set)) return true;
            }
            return false;
        }
    }
}
