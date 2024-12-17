namespace Blind75LeetCode.Services.Arrays._05_MaxSubArray;
public class MaxSubArrayService
{
    public static int BruteForce(int[] nums)
    {
        var cur = nums[0];
        var max = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            var val = nums[i];
            var sum = cur + val;
            cur = Math.Max(sum, val);
            max = Math.Max(max, cur);
            //if (cur > max)
            //    max = cur;
        }

        return max;
    }
}
