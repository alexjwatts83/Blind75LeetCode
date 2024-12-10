namespace Blind75LeetCode.Services.Arrays._01_TwoSum;

public class TwoSumService
{
    public static int[] Optimized(int[] nums, int target)
    {
        // nums = [2, 1, 3, 5, 8]
        // target = 9
        int[] ans = new int[2];
        Dictionary<int, int> map = new ();
        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];

            // if the map contains the difference
            if (!map.ContainsKey(diff))
            {
                map.Add(nums[i], i);
                continue;
            }
            ans[0] = map[diff];
            ans[1] = i;
            break;
            /* i  diff  map
             * 0  7     [[2, 0]]
             * 1  8     [[2, 0], [1, 1]]
             * 2  6     [[2, 0], [1, 1], [3,2]]
             * 3  4     [[2, 0], [1, 1], [3,2], [5, 3]]
             * 4  1     [[2, 0], [1, 1], [3,2], [5, 3]]
             */
        }
        return ans;
    }

    public static int[] BruteForce(int[] nums, int target)
    {
        // nums = [3, 2, 4]
        // target = 6
        // ans = [1, 2]

        int[] ans = new int[2];
        var found = false;
        for (int i = 0; i < nums.Length; i++)
        {
            var sumI = nums[i];
            var j = i + 1;
            while (i != j)
            {
                var sum = sumI + nums[j];
                if (sum == target) { 
                    ans[0] = i;
                    ans[1] = j;
                    found = true;
                    break;
                }

                j++;
                if (j == nums.Length)
                    j = 0;
            }
            if (found)
                break;
        }
        return ans;
    }
}
