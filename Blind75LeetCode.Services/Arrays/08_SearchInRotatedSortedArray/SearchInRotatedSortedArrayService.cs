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
        var search = -1;
        for (int i = 0; i < nums.Length; i++)
        {
        }

        return search;
    }
}
