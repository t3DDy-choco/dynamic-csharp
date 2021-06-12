using System;
using System.Collections.Generic;
using static StringConstructor.CanConstruct;
using static StringConstructor.CountConstruct;
using static StringConstructor.AllConstruct;

namespace StringConstructor
{
    class Program
    {
        static Dictionary<string, List<List<string>>> memo3 = new Dictionary<string, List<List<string>>>() 
        {
            {"", new List<List<string>>()}
        };

        static List<string> s0 = new List<string>() { "purp", "p", "ur", "le", "purpl" };
        static List<string> s1 = new List<string>() { "ab", "abc", "cd", "def", "abcd", "ef", "c" };
        static List<string> s2 = new List<string>() { "bo", "rd", "ate", "t", "ska", "sk", "boar" };
        static List<string> s3 = new List<string>() { "a", "p", "ent", "enter", "ot", "o", "t" };
        static List<string> s4 = new List<string>() { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" };

        static void Main(string[] args)
        {
            runner("purple", s0);
            runner("abcdef", s1);
            runner("skateboard", s2);
            runner("enterapotentpot", s3);
            runner("eeeeeeeeeeeeeeeeeeeeeeeeeeeeef", s4);
        }

        static void runner(string s, List<string> list) {
            Console.WriteLine(canConstruct_memo(s, list) + ":\t" + countConstruct_memo(s, list) + ":\t" + printer(allConstruct(s, list)));
        }
    }
}
