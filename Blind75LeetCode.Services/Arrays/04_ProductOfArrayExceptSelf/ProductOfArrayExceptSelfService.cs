using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Blind75LeetCode.Services.Arrays._04_ProductOfArrayExceptSelf;

public class ProductOfArrayExceptSelfService
{
    public static int[] UseDivision(int[] nums)
    {
        var answer = new int[nums.Length];
        var sum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == 0)
                continue;

            sum *= nums[i];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
                answer[i] = 0;
            else
                answer[i] = sum / nums[i];
        }

        return answer;
    }

    public static int[] PrefixAndSufficProduct(int[] nums)
    {
        var answer = new int[nums.Length];
        var prefix = new int[nums.Length];
        var suffix = new int[nums.Length];

        prefix[0] = nums[0];
        prefix[1] = nums[0];
        suffix[nums.Length - 1] = 1;
        suffix[nums.Length - 2] = nums[nums.Length - 1];
        // [-1, -1, 0, -3, 3]
        for (int i = 2; i < nums.Length; i++)
        {
            prefix[i] = prefix[i - 1] * nums[i - 1]; // look left for value 
        }

        for (int i = nums.Length - 2; i >= 0; i--)
        {
            var index = i + 1;
            var prev = suffix[index];
            var cur = nums[index];

            suffix[i] = suffix[i + 1] * nums[i + 1]; // look left for value 
        }

        for (int i = 0; i < nums.Length; i++)
        {
            answer[i] = prefix[i] * suffix[i];
        }

        return answer;
    }
}
