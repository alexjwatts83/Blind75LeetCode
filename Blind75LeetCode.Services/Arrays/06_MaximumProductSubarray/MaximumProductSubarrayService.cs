using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75LeetCode.Services.Arrays._06_MaximumProductSubarray;
public static class MaximumProductSubarrayService
{
    public static int BruteForce(int[] nums)
    {
        var max = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            var sum = nums[i];
            for (int j = i + 1; j < nums.Length; j++)
            {
                sum *= nums[j];
                max = Math.Max(max, sum);
            }
        }

        return max;
    }

    public static int Optimised(int[] nums)
    {
        var cur = nums[0];
        var max = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            var val = nums[i];
            var sum = cur * val;
            cur = Math.Max(sum, val);
            max = Math.Max(max, cur);
        }

        return max;
    }
}
