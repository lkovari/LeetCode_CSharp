﻿/*
    https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    121. Best Time to Buy and Sell Stock
    Easy

    You are given an array prices where prices[i] is the price of a given stock on the ith day.
    You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
    Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

    Example 1:
    Input: prices = [7,1,5,3,6,4]
    Output: 5
    Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
    Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.

    Example 2:
    Input: prices = [7,6,4,3,1]
    Output: 0
    Explanation: In this case, no transactions are done and the max profit = 0.

    Constraints:
    1 <= prices.length <= 105
    0 <= prices[i] <= 104
 */

namespace LeetCode
{
    internal class BestTimeToBuyAndSell_121
    {

        static void Main(string[] args)
        {
            Console.WriteLine("LeetCode: 121. Best Time To Buy And Sell solution");
            var prices = new int[] { 7, 1, 5, 3, 6, 4 };
            var solution = new Solution();
            var maxProfit = solution.MaxProfit(prices);
            Console.WriteLine($"          121. Best Time To Buy And Sell Max Profit: {maxProfit}");
        }
    }

    public class Solution
    {
        private const int first_item = 0;
        private const int second_item = 1;

        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int buyStock = prices[first_item];
            int itemsCount = prices.Count();
            for (int day = second_item; day < itemsCount; day++)
            {
                buyStock = (buyStock > prices[day]) ? prices[day] : buyStock;
                int profit = prices[day] - buyStock;
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }
            return maxProfit;
        }
    }
}




