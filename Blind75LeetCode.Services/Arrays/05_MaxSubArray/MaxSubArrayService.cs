namespace Blind75LeetCode.Services.Arrays._05_MaxSubArray;
public class MaxSubArrayService
{
    public static int[] BruteForce(int[] nums)
    {
        // [-2, 1, -3, 4, -1, 2, 1, -5, 4]
        // [-2, -1, -4, 0, -1, 1, 2, -3, 0
        var startIndex = 0;
        var endIndex = 0;
        var sum = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            // i = 1
            // sum = -2
            // curSum = -2 + 1 = -1

            // i = 2
            // sum = -1
            // curSum = -1 + (-3) = -4
            var curSum = nums[i] + sum;
            if (curSum > sum)
            {
                sum = curSum;
                endIndex = i;
                continue;
            }
            startIndex = i;
            sum = nums[i];

            for (int j = 1; j < nums.Length; j++)
            {

            }
        }

        return nums;
    }
}
