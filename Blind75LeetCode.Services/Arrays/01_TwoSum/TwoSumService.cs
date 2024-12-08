namespace Blind75LeetCode.Services.Arrays._01_TwoSum;

public class TwoSumService
{
    public static int[] TwoSum(int[] nums, int target)
    {
        int[] ans = new int[2];
        Dictionary<int, int> map = new ();
        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (!map.ContainsKey(diff))
            {
                map.Add(nums[i], i);
            }
            else
            {
                ans[0] = i;
                ans[1] = map[diff];
                break;
            }
        }
        return ans;
    }
}
