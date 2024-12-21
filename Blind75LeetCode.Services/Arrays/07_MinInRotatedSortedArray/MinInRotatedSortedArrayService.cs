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
        var left = nums[0];
        var right = nums[nums.Length - 1];
        var mid = nums.Length / 2;

        //while(true)
        //{
        //    // if 
        //}

        return 0;
    }
}
