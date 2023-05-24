//-----------------------------------------------------------------------------
// Runtime: 112ms
// Memory Usage: 31.4 MB
// Link: https://leetcode.com/submissions/detail/342501480/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _0217_ContainsDuplicate
    {
        // Simple solution
        // Time Complexity: O(n^2)
        // Space Complexity: O(n^2)
        // Simple Approach with double loops
        //public bool ContainsDuplicate(int[] nums)
        //{

        //    //1 2 3 4
        //    //0 1 2 3
        //    for (int i = 0; i < nums.Length - 1; i++)
        //    {
        //        for (int j = i + 1; j < nums.Length; j++)
        //        {
        //            if (nums[i] == nums[j])
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}

        // Time Complexity: O(1)
        // Space Complexity: O(n)
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> hashset = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hashset.Contains(nums[i]))
                {
                    return true;
                }
                hashset.Add(nums[i]);
            }
            return false;
        }
    }
}
