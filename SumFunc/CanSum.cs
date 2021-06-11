using System.Collections.Generic;

namespace SumFunc
{
    public class CanSum
    {
        public static bool canSum(int targetSum, int[] set)
        {
            if (targetSum == 0) return true;
            if (targetSum < 0) return false;
            foreach (int num in set)
            {
                int remainder = targetSum - num;
                if (canSum(remainder, set)) return true;
            }
            return false;
        }

        public static bool canSum_memo(int target, int[] set, Dictionary<int, bool> _memo)
        {
            if (_memo.ContainsKey(target)) return _memo[target];
            if (target < 0) return false;
            foreach (int num in set)
            {
                int remainder = target - num;
                if (canSum_memo(remainder, set, _memo))
                {
                    _memo.Add(target, true);
                    return true;
                }
            }
            _memo.Add(target, false);
            return false;
        }
    }
}