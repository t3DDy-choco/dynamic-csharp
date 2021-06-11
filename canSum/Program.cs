using System;
using System.Collections.Generic;

namespace canSum
{
    class Program
    {
        static Dictionary<int, bool> _memo = new Dictionary<int, bool>() {
            {0, true}
        };

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
            Console.WriteLine(canSum_memo(300, a5, _memo));
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

        static bool canSum_memo(int target, int[] set, Dictionary<int, bool> _memo)
        {
            if (_memo.ContainsKey(target)) return _memo[target];
            if (target < 0) return false;
            foreach (int num in set)
            {
                int remainder = target - num;
                if (canSum_memo(remainder, set, _memo))
                {
                    _memo.Add(target, true);
                    return true;
                }
            }
            _memo.Add(target, false);
            return false;
        }
    }
}
