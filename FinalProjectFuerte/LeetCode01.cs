using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectFuerte
{
    public class LeetCode01
    {
        /// <summary>
        /// Leetcode solution program
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0)
                return 0;

            int firstBuy = int.MinValue;
            int firstSell = 0;
            int secondBuy = int.MinValue;
            int secondSell = 0;

            foreach (int price in prices)
            {
                firstBuy = Math.Max(firstBuy, -price);
                firstSell = Math.Max(firstSell, firstBuy + price);
                secondBuy = Math.Max(secondBuy, firstSell - price);
                secondSell = Math.Max(secondSell, secondBuy + price);
            }

            return secondSell;
        }
    }
}
