using System;

namespace FinalProjectFuerte
{
    public class LeetCode04
    {
        public int Trap(int[] height)
        {
            int left = 0, right = height.Length - 1;
            int leftMax = 0, rightMax = 0;
            int trappedWater = 0;

            while (left < right)
            {
                if (height[left] < height[right])
                {
                    if (height[left] >= leftMax)
                    {
                        leftMax = height[left];
                    }
                    else
                    {
                        trappedWater += leftMax - height[left];
                    }
                    left++;
                }
                else
                {
                    if (height[right] >= rightMax)
                    {
                        rightMax = height[right];
                    }
                    else
                    {
                        trappedWater += rightMax - height[right];
                    }
                    right--;
                }
            }

            return trappedWater;
        }

        public static void Main()
        {
            int[] elevationMap = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            LeetCode04 solution = new LeetCode04();
            int result = solution.Trap(elevationMap);
            Console.WriteLine("Trapped Water: " + result); // Output: 6
        }
    }
}
