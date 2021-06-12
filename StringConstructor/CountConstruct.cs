using System.Collections.Generic;

namespace StringConstructor {
    class CountConstruct {
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

        public static void countConstruct_memo() {}
    }
}