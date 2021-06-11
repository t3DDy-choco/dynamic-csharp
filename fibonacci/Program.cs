using System;
using System.Collections.Generic;

namespace fibonacci
{
    class Program
    {
        static Dictionary<int, ulong> memo = new Dictionary<int, ulong>() {
            {0, 0},
            {1, 1},
            {2, 1}
        };
        static void Main(string[] args)
        {
            // Getting Factorial with old standard method
            // Console.WriteLine(old_fib(45));
            Console.WriteLine(memo_fib(450, memo));
        }

        static int old_fib(int n)
        {
            if (n <= 2) return 1;
            return old_fib(n - 1) + old_fib(n - 2);
        }

        static ulong memo_fib(int n, Dictionary<int, ulong> memo)
        {
            if (memo.ContainsKey(n)) return memo[n];
            else memo.Add(n, memo_fib(n - 1, memo) + memo_fib(n - 2, memo));
            return memo[n];
        }
    }
}