﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75LeetCode.Services.Arrays._03_ContainsDuplicate;
public class ContainsDuplicateService
{
    public static bool BruteForce(int[] nums)
    {
        var containsDuplicates = false;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)
                    continue;

                if (nums[i] == nums[j])
                    containsDuplicates = true;
            }
            if (containsDuplicates)
                break;
        }

        return containsDuplicates;
    }
}
