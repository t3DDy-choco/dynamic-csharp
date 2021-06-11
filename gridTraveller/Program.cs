using System;
using System.Collections.Generic;

namespace gridTraveller
{
    class Program
    {
        static Dictionary<string, ulong> _memo = new Dictionary<string, ulong>() {
            {"1,1", 1}
        };

        static void Main(string[] args)
        {
            Console.WriteLine(travel(0, 1));
            Console.WriteLine(travel(1, 1));
            Console.WriteLine(travel(3, 3));
            Console.WriteLine(travel_memo(1500, 1500, _memo));
        }

        static int travel(int r, int c)
        {
            if (r == 1 && c == 1) return 1;
            if (r == 0 || c == 0) return 0;
            return travel(r - 1, c) + travel(r, c - 1);
        }

        static ulong travel_memo(int r, int c, Dictionary<string, ulong> _memo)
        {
            string key = $"{r},{c}";
            string revKey = $"{c},{r}";
            if (_memo.ContainsKey(key)) return _memo[key];
            else if (_memo.ContainsKey(revKey)) return _memo[revKey];
            else if (r == 0 || c == 0) _memo.Add(key, 0);
            else _memo.Add(key, travel_memo(r - 1, c, _memo) + travel_memo(r, c - 1, _memo));
            return _memo[key];
        }
    }
}
