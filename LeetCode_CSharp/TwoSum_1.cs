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
