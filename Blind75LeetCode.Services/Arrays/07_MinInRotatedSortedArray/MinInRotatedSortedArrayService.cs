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
        if (nums.Length == 1) return nums[0];
        if (nums.Length == 2) return Math.Min(nums[0], nums[1]);
        if (nums[0] < nums[nums.Length - 1]) return nums[0];


        // { 6, 7, 8, 9, 0, 1, 2, 3, 4, 5 }
        // len = 10;
        var leftIndex = 0;
        var rightIndex = nums.Length - 1;
        
        while (leftIndex <= rightIndex) {
            var midIndex = leftIndex + (rightIndex - leftIndex) / 2; // could cause out of bound index
            // is decreasing at mid + 1
            var midVal = nums[midIndex];
            var midPlusOneVal = nums[midIndex + 1];
            if (midVal > midPlusOneVal) 
                return midPlusOneVal;

            // is decreasing at mid
            var midMinusOneVal = nums[midIndex - 1];
            if (midMinusOneVal > midVal)
                return midVal;

            var leftVal = nums[leftIndex];
            if (leftVal < midVal)
            {
                // lef to mid is sorted
                leftIndex = midIndex + 1;
            } else
            {
                rightIndex = midIndex - 1;  
            } 
        }

        return -1;
    }
}
