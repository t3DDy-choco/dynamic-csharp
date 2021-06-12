using System.Collections.Generic;

namespace StringConstructor
{
    class CanConstruct
    {
        static Dictionary<string, bool> memo = new Dictionary<string, bool>() { {"", true} };

        public static bool canConstruct(string target, List<string> wordBank) {
            if (target == "") return true;

            foreach (string word in wordBank)
            {
                if (target.IndexOf(word) == 0) 
                {
                    string suffix = target.Substring(word.Length);
                    if (canConstruct(suffix, wordBank)) return true;
                }
            }

            return false;
        }

        public static bool canConstruct_memo(string target, List<string> wordBank) {
            if (memo.ContainsKey(target)) return memo[target];

            foreach (string word in wordBank)
            {
                if (target.IndexOf(word) == 0) 
                {
                    string suffix = target.Substring(word.Length);
                    if (canConstruct_memo(suffix, wordBank)) {
                        memo.Add(target, true);
                    }
                }
            }

            memo.Add(target, false);
            return memo[target];
        }
    }
}