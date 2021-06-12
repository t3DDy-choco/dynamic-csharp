using System;
using System.Collections.Generic;

namespace StringConstructor
{
    class Program
    {
        static List<string> s1 = new List<string>() {
            "ab", "abc", "cd", "def", "abcd"
        };

        static List<string> s2 = new List<string>() {
            "bo", "rd", "ate", "t", "ska", "sk", "boar"
        };

        static List<string> s3 = new List<string>() {
            "a", "p", "ent", "enter", "ot", "o", "t"
        };

        static List<string> s4 = new List<string>() {
            "e", "ee", "eee", "eeee", "eeeee", "eeeeee"
        };

        static void Main(string[] args)
        {
            Console.WriteLine(CanConstruct.canConstruct("abcdef", s1));
            Console.WriteLine(CanConstruct.canConstruct("skateboard", s2));
            Console.WriteLine(CanConstruct.canConstruct("enterapotentpot", s3));
            Console.WriteLine(CanConstruct.canConstruct_memo("eeeeeeeeeeeeeeeeeeeeeeeeeeeeef", s4));
        }
    }
}
