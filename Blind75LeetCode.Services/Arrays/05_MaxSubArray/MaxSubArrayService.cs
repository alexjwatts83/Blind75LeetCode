namespace Blind75LeetCode.Services.Arrays._05_MaxSubArray;
public class MaxSubArrayService
{
    public static int Optimised(int[] nums)
    {
        var cur = nums[0];
        var max = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            var val = nums[i];
            var sum = cur + val;
            cur = Math.Max(sum, val);
            max = Math.Max(max, cur);
        }

        return max;
    }

    public static int BruteForce(int[] nums)
    {
        var max = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            var sum = 0;
            for (int j = i; j < nums.Length; j++)
            {
                sum += nums[j];
                max = Math.Max(max, sum);
            }
        }

        return max;
    }
}
