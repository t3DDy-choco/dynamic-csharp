using System;
using System.Collections.Generic;
using System.Collections;

namespace canSum
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
            Console.Write(canSum(7, a1) + ": "); PrintValues(howSum(7, a1));
            Console.Write(canSum(7, a2) + ": "); PrintValues(howSum(7, a2));
            Console.Write(canSum(7, a3) + ": "); PrintValues(howSum(7, a3));
            Console.Write(canSum(8, a4) + ": "); PrintValues(howSum(8, a4));
            Console.Write(canSum_memo(300, a5, _memo) + ": "); PrintValues(howSum_memo(300, a5, _memo2));
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

        static ArrayList howSum(int target, int[] set)
        {
            if (target == 0) return new ArrayList();
            if (target < 0) return null;
            foreach (int num in set)
            {
                int remainder = target - num;
                ArrayList result = howSum(remainder, set);
                if (result != null)
                {
                    result.Add(num);
                    return result;
                }
            }
            return null;
        }

        static ArrayList howSum_memo(int target, int[] set, Dictionary<int, ArrayList> _memo)
        {
            if (_memo.ContainsKey(target)) return _memo[target];
            if (target < 0) return null;
            foreach (int num in set)
            {
                int remainder = target - num;
                ArrayList result = howSum_memo(remainder, set, _memo);
                if (result != null)
                {
                    result.Add(num);
                    _memo.Add(target, result);
                    return _memo[target];
                }
            }
            _memo[target] = null;
            return null;
        }
    }
}
