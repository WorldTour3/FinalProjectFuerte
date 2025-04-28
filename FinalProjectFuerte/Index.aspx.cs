using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace FinalProjectFuerte
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Leetcode01 button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LeetCodeButton01_Click(object sender, EventArgs e)
        {
            // LeetCode01 problem context
            string description = @"You are given an array prices where prices[i] is the price of a given stock on the ith day.

  Find the maximum profit you can achieve. You may complete at most two transactions.

Note: You may not engage in multiple transactions simultaneously (i.e., you must sell the stock before you buy again).

Example:
Input: prices = [3,3,5,0,0,3,1,4]
Output: 6
Explanation: Buy on day 4 (price = 0) and sell on day 6 (price = 3), profit = 3-0 = 3.
Then buy on day 7 (price = 1) and sell on day 8 (price = 4), profit = 4-1 = 3.
";

            // Solve the problem
            LeetCode01 solver = new LeetCode01();
            int[] prices = { 3, 3, 5, 0, 0, 3, 1, 4 };
            int result = solver.MaxProfit(prices);

            // Display everything
            ProblemLabel.Text = description.Replace("\n", "<br/>").Replace(" ", "&nbsp;");
            ResultLabel.Text = "<b>Max profit is: " + result + "</b>";
        }

        protected void LeetCodeButton02_Click(object sender, EventArgs e)
        {
            //LeetCode02 Problem
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            string description = "@There are n children standing in a line. Each child is " +
   "assigned a rating value given in the integer array ratings.You are " +
   "giving candies to these children subjected to the following requirements:" +
   "Each child must have at least one candy.Children with a higher " +
   "rating get more candies than their neighbors.Return the minimum number of" +
   " candies you need to have to distribute the candies to the children. " +

   "Example 1:Input: ratings = [1,0,2]Output: 5 Explanation" +
    ": You can allocate to the first, second and third child with 2, 1, 2 candies " +
    "respectively.";
#pragma warning restore CS0219 // Variable is assigned but its value is never used
            
            //Solve problem
            LeetCode02 solver = new LeetCode02();
            int[] ratings = { 1, 0, 2 };
            int result = solver.Candy(ratings);
            //Display
            ProblemLabel.Text = description.Replace("\n", "<br/>").Replace(" ", "&nbsp;");
            Console.WriteLine($"Minimum Candies needed: :{result}");
        }
        protected void ClearButton_Click(object sender, EventArgs e)
        {
            ClearInputs(Page.Controls);
        }
        void ClearInputs(ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = string.Empty;
                ClearInputs(ctrl.Controls);
            }
        }

        /// <summary>
        /// Leedcode button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LeetCodeButton04_Click(object sender, EventArgs e)
        {
            // Problem description
            string description = @"Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.
              
            Example:
            Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
            Output: 6";

            // Solve the problem
            LeetCode04 solver = new LeetCode04();
            int[] elevationMap = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            int result = solver.Trap(elevationMap);

            // Display results
            ProblemLabel.Text = description.Replace("\n", "<br/>").Replace(" ", "&nbsp;");
            ResultLabel.Text = "<b>Trapped Water: " + result + "</b>";
        }

    }
}

