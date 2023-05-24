//-----------------------------------------------------------------------------
// Runtime: 104ms
// Memory Usage: 28.8 MB
// Link: https://leetcode.com/submissions/detail/261553087/
//-----------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _0169_MajorityElement
    {
        public int MajorityElement(int[] nums)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }
            // TODO: find a better solution by finding a candidate
            var mostRepeatedElement = dict.OrderByDescending(c => c.Value).First().Key;
            return mostRepeatedElement;
        }
    }
}
