using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75LeetCode.Services.Arrays._02_BestTimeToBuyAndSellStock;
public class BestTimeToBuyAndSellStockService
{
    public static int Run(int[] nums)
    {
        var answer = 0;

        // loop through the numbers
        Dictionary<int, int> map = new();
        for (int i = 0; i < nums.Length; i++)
        {
            var biggest = -1;
            var value = nums[i];
            for (int j = i + 1; j < nums.Length; j++)
            {
                var secondValue = nums[j];
                var diff = secondValue - value;
                if (diff > biggest)
                    biggest = diff;
            }
            if (biggest > answer)
                answer = biggest;
        }

        return answer;
    }
}
