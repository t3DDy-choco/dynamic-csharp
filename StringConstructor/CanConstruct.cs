using System.Collections.Generic;

namespace StringConstructor
{
    class CanConstruct
    {
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
    }
}