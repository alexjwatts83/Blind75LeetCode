namespace Blind75LeetCode.Services.Arrays._05_MaxSubArray;
public class MaxSubArrayService
{
    public static int[] BruteForce(int[] nums)
    {
        var startIndex = 0;
        var endIndex = 0;
        var sum = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            // i = 1
            // sum = -2
            var curSum = nums[i] + sum;
            if (curSum > sum)
            {
                sum = curSum;
                continue;
            }

            for (int j = 1; j < nums.Length; j++)
            {

            }
        }

        return nums;
    }
}
