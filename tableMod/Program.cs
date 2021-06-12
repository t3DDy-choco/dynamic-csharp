using System;

namespace tableMod {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(fib(50));
            Console.WriteLine(grid(18, 18));
            Console.WriteLine(canSum(7, new int[] {2, 3}));
            Console.WriteLine(canSum(7, new int[] {5, 3, 4, 7}));
            Console.WriteLine(canSum(7, new int[] {2, 4}));
            Console.WriteLine(canSum(8, new int[] {2, 3, 5}));
            Console.WriteLine(canSum(300, new int[] {7, 14}));
        }

        static long fib(int n) {
            long[] table = new long[n + 1];
            for (int i = 0; i <= n; i++) table[i] = 0;
            table[1] = 1;

            for (int i = 2; i <= n; i++) table[i] = table[i - 1] + table[i - 2];

            return table[n];
        }

        static long grid(int m, int n) {
            long[,] table = new long[m + 1, n + 1];
            for (int i = 0; i <= m; i++) 
                for (int j = 0; j <= n; j++) 
                    table[m,n] = 0;
            table[1,1] = 1;
            
            for (int i = 0; i <= m; i++) {
                for (int j = 0; j <= n; j++) {
                    if (i < m) table[i + 1,j] += table[i,j];
                    if (j < n) table[i,j + 1] += table[i,j];
                }
            }

            return table[m,n];
        }

        static bool canSum(int n, int[] list) {
            bool[] table = new bool[n + 1];
            for (int i = 1; i <= n; i++) table[i] = false;
            table[0] = true;

            for (int i = 0; i < n; i++) {
                if (table[i] == true) {
                    foreach (int x in list)
                    {
                        if (i + x <= n) table[i + x] = true;
                    }
                }
            }

            return table[n];
        }

        static void print(int[] arr) { 
            foreach (int n in arr) Console.Write($"{n},"); 
        }

        static void print(bool[] arr) { 
            foreach (bool n in arr) Console.Write($"{n},"); 
        }

        static void print(long[,] arr) {
            for (int i = 0; i < arr.GetLength(0); i++) {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write($"{arr[i,j]},"); 
                Console.WriteLine();
            }
        }
    }
}
