/*
    1. Two Sum
    Easy

    Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    You may assume that each input would have exactly one solution, and you may not use the same element twice.
    You can return the answer in any order.

    Example 1:
    Input: nums = [2,7,11,15], target = 9
    Output: [0,1]
    Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

    Example 2:
    Input: nums = [3,2,4], target = 6
    Output: [1,2]

    Example 3:
    Input: nums = [3,3], target = 6
    Output: [0,1]

    Constraints:

    2 <= nums.length <= 104
    -109 <= nums[i] <= 109
    -109 <= target <= 109
    Only one valid answer exists. 
 */
namespace LeetCode
{
    public class SolutionOfTwoSum
    {
        private int itemsCount = 0;
        private const int firstItem = 0;

        public int[] TwoSum(int[] nums, int target)
        {
            int[] res = new int[2];
            itemsCount = nums.Count();
            for (int ix = firstItem; ix < itemsCount; ix++)
            {
                int itemA = nums[ix];
                bool found = false; ;
                for (int idx = ix + 1; idx < itemsCount; idx++)
                {
                    if (nums[idx] == (target - itemA))
                    {
                        res[0] = ix;
                        res[1] = idx;
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }
            return res;
        }
    }
}
