using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75LeetCode.Services.Arrays._02_BestTimeToBuyAndSellStock;
public class BestTimeToBuyAndSellStockService
{
    public static int BruteForce(int[] nums)
    {
        var answer = 0;

        // loop through the numbers
        for (int i = 0; i < nums.Length; i++)
        {
            var biggest = -1;
            var value = nums[i];
            for (int j = i + 1; j < nums.Length; j++)
            {
                var secondValue = nums[j];
                var diff = secondValue - value;
                if (diff > biggest)
                    biggest = diff;
            }
            if (biggest > answer)
                answer = biggest;
        }

        return answer;
        // TC: O(n^2)
        // SC: O(1)
    }

    public static int Optimised(int[] nums)
    {
        // 7, 1, 5, 3, 5, 4
        var answer = 0;
        var minPrice = nums[0];
        // loop through the numbers
        for (int i = 1; i < nums.Length; i++)
        {
            var value = nums[i] - minPrice;
            if (value > answer)
                answer = value;

            if (nums[i] < minPrice )
                minPrice = nums[i];
        }

        return answer;
        // TC: O(n)
        // SC: O(1)
    }
}
