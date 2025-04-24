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

        protected void LeetCodeButton01_Click(object sender, EventArgs e)
        {
            // LeetCode problem context
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
    }
}

