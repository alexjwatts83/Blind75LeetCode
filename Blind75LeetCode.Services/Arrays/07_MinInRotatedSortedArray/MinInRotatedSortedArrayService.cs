namespace Blind75LeetCode.Services.Arrays._07_MinInRotatedSortedArray;
public static class MinInRotatedSortedArrayService
{
    public static int BruteForce(int[] nums)
    {
        // { 6, 7, 8, 9, 0, 1, 2, 3, 4, 5 }
        var min = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            if (min > nums[i])
            {
                min = nums[i];
                break;
            }
        }

        return min;
    }

    public static int Optimised(int[] nums)
    {
        // { 6, 7, 8, 9, 0, 1, 2, 3, 4, 5 }
        // len = 10;
        var leftIndex = 0;
        var rightIndex = nums.Length - 1;
        var midIndex = leftIndex + rightIndex / 2;
        while (true) {
            var numMid = nums[midIndex];
            var numMidPlusOne = nums[midIndex + 1];
            if (numMid < numMidPlusOne)
            {
                return numMid;
            }
            // { 8, 9, 0, 1, 2, 3, 4, 5, 6, 7 }
            // { 2, 3, 4, 5, 6, 7, 8, 9, 0, 1 }
            // check if left is sorted
            var numLeft = nums[leftIndex];
            var numRight = nums[rightIndex];
            if (numLeft < numMid)
            {
                leftIndex = midIndex;
                midIndex = leftIndex + rightIndex / 2;
            } else
            {
                rightIndex = midIndex;
                midIndex = leftIndex + rightIndex / 2;
            }
        }
    }
}
