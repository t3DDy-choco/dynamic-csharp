using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // Getting Factorial with old standard method
            Console.WriteLine(old_fib(5));
        }

        static int old_fib(int n)
        {
            if (n <= 2) return 1;
            return old_fib(n - 1) + old_fib(n - 2);
        }
    }
}