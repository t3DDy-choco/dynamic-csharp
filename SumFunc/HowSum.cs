using System.Collections;
using System.Collections.Generic;

namespace SumFunc
{
    public class HowSum
    {
        public static ArrayList howSum(int target, int[] set)
        {
            if (target == 0) return new ArrayList();
            if (target < 0) return null;
            foreach (int num in set)
            {
                int remainder = target - num;
                ArrayList result = howSum(remainder, set);
                if (result != null)
                {
                    result.Add(num);
                    return result;
                }
            }
            return null;
        }

        public static ArrayList howSum_memo(int target, int[] set, Dictionary<int, ArrayList> _memo)
        {
            if (_memo.ContainsKey(target)) return _memo[target];
            if (target < 0) return null;
            foreach (int num in set)
            {
                int remainder = target - num;
                ArrayList result = howSum_memo(remainder, set, _memo);
                if (result != null)
                {
                    result.Add(num);
                    _memo.Add(target, result);
                    return _memo[target];
                }
            }
            _memo[target] = null;
            return null;
        }
    }
}