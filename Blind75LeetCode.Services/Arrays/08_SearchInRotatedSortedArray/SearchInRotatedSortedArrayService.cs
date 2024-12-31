using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75LeetCode.Services.Arrays._08_SearchInRotatedSortedArray;

public static class SearchInRotatedSortedArrayService
{
    public static int BruteForce(int[] nums, int target)
    {
        var search = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            if(target == nums[i])
                return i;
        }

        return search;
    }

    public static int Optimised(int[] nums, int target)
    {
        var leftIndex = 0;
        var rightIndex = nums.Length - 1;

        // 4, 5, 6, 7, 0, 1, 2
        // 6, 7, 8, 9, 0, 1, 2, 3, 4, 5
        while (leftIndex <= rightIndex)
        {
            var midIndex = leftIndex + (rightIndex - leftIndex) / 2; // could cause out of bound index
            var midVal = nums[midIndex];
            if (midVal == target)
            {
                return midIndex;
            }

            var leftVal = nums[leftIndex];
            if (leftVal == target)
                return leftIndex;

            // is left to middle sorted
            if (leftVal < midVal)
            {
                // left to mid is sorted
                leftIndex = midIndex + 1;
            }
            else
            {
                var rightVal = nums[rightIndex];
                if (rightVal == target)
                    return rightIndex;
                // right to middle is sorted

                // does mid to right contain target
                if (midVal > target && target < rightVal)
                {

                }
            }
        }

        return -1;
    }
}
