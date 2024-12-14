namespace Blind75LeetCode.Services.Arrays._04_ProductOfArrayExceptSelf;

public class ProductOfArrayExceptSelfService
{
    public static int[] BruteForce(int[] nums)
    {
        // [-1, -1, 0, -3, 3]
        var answer = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            var product = 1;
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)
                    continue;
                product *= nums[j];
            }
            answer[i] = product;
        }

        return answer;
    }

    public static int[] UseDivision(int[] nums)
    {
        var answer = new int[nums.Length];
        var sum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == 0)
                continue;

            sum *= nums[i];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
                answer[i] = 0;
            else
                answer[i] = sum / nums[i];
        }

        return answer;
    }

    public static int[] PrefixAndSufficProduct(int[] nums)
    {
        var answer = new int[nums.Length];
        var prefix = new int[nums.Length];
        var suffix = new int[nums.Length];

        prefix[0] = nums[0];
        prefix[1] = nums[0];
        suffix[nums.Length - 1] = 1;
        suffix[nums.Length - 2] = nums[nums.Length - 1];

        // [-1, -1, 0, -3, 3]
        for (int i = 2; i < nums.Length; i++)
        {
            prefix[i] = prefix[i - 1] * nums[i - 1]; // look left for value 
        }

        for (int i = nums.Length - 2; i >= 0; i--)
        {
            suffix[i] = suffix[i + 1] * nums[i + 1]; // look right for value 
        }

        for (int i = 0; i < nums.Length; i++)
        {
            answer[i] = prefix[i] * suffix[i];
        }

        return answer;
    }

    public static int[] PrefixProductOnly(int[] nums)
    {
        var answer = new int[nums.Length];
        var prefix = new int[nums.Length];

        // [-1, -1, 0, -3, 3]
        for (int i = 0; i < nums.Length; i++)
        {
            answer[i] = prefix[i];
        }

        return answer;
    }
}
