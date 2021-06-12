using System.Collections.Generic;

namespace StringConstructor {
    class CountConstruct {
        static Dictionary<string, int> memo = new Dictionary<string, int>() { {"", 1} };

        public static int countConstruct(string target, List<string> wordBank) {
            if (target == "") return 1 ;

            int totalCount = 0;

            foreach (string word in wordBank)
            {
                if (target.IndexOf(word) == 0) 
                {
                    string suffix = target.Substring(word.Length);
                    int waysToConstruct = countConstruct(suffix, wordBank);
                    totalCount += waysToConstruct;
                }
            }

            return totalCount;
        }

        public static int countConstruct_memo(string target, List<string> wordBank) {
            if (memo.ContainsKey(target)) return memo[target];

            int totalCount = 0;

            foreach (string word in wordBank)
            {
                if (target.IndexOf(word) == 0) 
                {
                    string suffix = target.Substring(word.Length);
                    int waysToConstruct = countConstruct_memo(suffix, wordBank);
                    totalCount += waysToConstruct;
                }
            }
            memo.Add(target, totalCount);
            return totalCount;
        }
    }
}