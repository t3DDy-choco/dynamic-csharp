using System;

namespace gridTraveller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(travel(0, 1));
            Console.WriteLine(travel(1, 1));
            Console.WriteLine(travel(3, 3));
            Console.WriteLine(travel(100, 100));
        }

        static int travel(int rows, int columns)
        {
            if (rows == 1 && columns == 1) return 1;
            if (rows == 0 || columns == 0) return 0;
            return travel(rows - 1, columns) + travel(rows, columns - 1);
        }
    }
}
