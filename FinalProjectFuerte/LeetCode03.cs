using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectFuerte
{
    public class LeetCode03
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
                return FindMedianSortedArrays(nums2, nums1);

            int m = nums1.Length, n = nums2.Length;
            int left = 0, right = m, halfLen = (m + n + 1) / 2;

            while (left <= right)
            {
                int i = (left + right) / 2;
                int j = halfLen - i;

                if (i < m && j > 0 && nums2[j - 1] > nums1[i])
                {
                    left = i + 1;
                }
                else if (i > 0 && j < n && nums1[i - 1] > nums2[j])
                {
                    right = i - 1;
                }
                else
                {
                    int maxLeft;
                    if (i == 0) maxLeft = nums2[j - 1];
                    else if (j == 0) maxLeft = nums1[i - 1];
                    else maxLeft = Math.Max(nums1[i - 1], nums2[j - 1]);

                    if ((m + n) % 2 == 1)
                        return maxLeft;

                    int minRight;
                    if (i == m) minRight = nums2[j];
                    else if (j == n) minRight = nums1[i];
                    else minRight = Math.Min(nums1[i], nums2[j]);

                    return (maxLeft + minRight) / 2.0;
                }
            }

            throw new ArgumentException("Input arrays are not sorted or have invalid lengths.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var solution = new LeetCode03();

            // Example 1
            int[] nums1a = { 1, 3 };
            int[] nums2a = { 2 };
            double median1 = solution.FindMedianSortedArrays(nums1a, nums2a);
            Console.WriteLine($"Median of [1,3] and [2] is {median1:F5}");

            // Example 2
            int[] nums1b = { 1, 2 };
            int[] nums2b = { 3, 4 };
            double median2 = solution.FindMedianSortedArrays(nums1b, nums2b);
            Console.WriteLine($"Median of [1,2] and [3,4] is {median2:F5}");
        }
    
}
}