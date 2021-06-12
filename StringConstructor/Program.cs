using System;
using System.Collections.Generic;
using static StringConstructor.CanConstruct;
using static StringConstructor.CountConstruct;

namespace StringConstructor
{
    class Program
    {
        static List<string> s0 = new List<string>() {
            "purp", "p", "ur", "le", "purpl"
        };

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
            Console.WriteLine(canConstruct("purple", s0) + ": " + countConstruct("purple", s0));
            Console.WriteLine(canConstruct("abcdef", s1) + ": " + countConstruct("abcdef", s1));
            Console.WriteLine(canConstruct("skateboard", s2) + ": " + countConstruct("skateboard", s2));
            Console.WriteLine(canConstruct("enterapotentpot", s3) + ": " + countConstruct("enterapotentpot", s3));
            Console.WriteLine(canConstruct_memo("eeeeeeeeeeeeeeeeeeeeeeeeeeeeef", s4) + ": " + countConstruct_memo("eeeeeeeeeeeeeeeeeeeeeeeeeeeeef", s4));
        }
    }
}
