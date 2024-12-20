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
        var answer = nums[0];
        var min = 1;
        var max = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            var val = nums[i];
            if (val == 0)
            {
                min = 1;
                max = 1;
                continue;
            }
            var valTimesMin = val * min;
            var valTimesMax = val * max;

            min = Math.Min(val, Math.Min(valTimesMin, valTimesMax));
            max = Math.Max(val, Math.Max(valTimesMin, valTimesMax));
            answer = Math.Max (answer, max);

            if (max > answer)
                answer = max;
        }

        return answer;
    }
}
