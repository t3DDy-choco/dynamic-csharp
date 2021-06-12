using System.Collections.Generic;

namespace SumFunc
{
    public class BestSum
    {
        public static List<int> bestSum(int target, int[] set)
        {
            if (target == 0) return new List<int>();
            if (target < 0) return null;

            List<int> bestCombination = null;

            foreach (int num in set)
            {
                int remainder = target - num;
                List<int> result = bestSum(remainder, set);
                if (result != null)
                {
                    result.Add(num);
                    if (bestCombination ==  null || result.Count < bestCombination.Count) {
                        bestCombination = new List<int>(result);
                    }
                }
            }
            return bestCombination;
        }

        public static List<int> bestSum_memo(int target, int[] set, Dictionary<int, List<int>> _memo)
        {
            if (_memo.ContainsKey(target)) return _memo[target];
            if (target == 0) return new List<int>();
            if (target < 0) return null;

            List<int> bestCombination = null;

            foreach (int num in set)
            {
                int remainder = target - num;
                List<int> result = bestSum_memo(remainder, set, _memo);
                if (result != null)
                {
                    result.Add(num);
                    if (bestCombination ==  null) bestCombination = result;
                    else if (result.Count < bestCombination.Count) bestCombination = result;
                }
            }
            _memo.Add(target, bestCombination);
            return bestCombination;
        }
    }
}