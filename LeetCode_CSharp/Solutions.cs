using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LeetCode
{
    internal class Solutions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LeetCode: 1. Two Sum solution");
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var solution_1 = new SolutionOfTwoSum();
            var outArray = solution_1.TwoSum(nums, target);
            JObject json = new JObject();
            Console.WriteLine($"          1. Two Sum Target: {JsonConvert.SerializeObject(outArray)}");

            Console.WriteLine("LeetCode: 121. Best Time To Buy And Sell solution");
            var prices = new int[] { 7, 1, 5, 3, 6, 4 };
            var solution_121 = new SolutionOfBestTimeToBuyAndSell();
            var maxProfit = solution_121.MaxProfit(prices);
            Console.WriteLine($"          121. Best Time To Buy And Sell Max Profit: {maxProfit}");
        }
    }
}
