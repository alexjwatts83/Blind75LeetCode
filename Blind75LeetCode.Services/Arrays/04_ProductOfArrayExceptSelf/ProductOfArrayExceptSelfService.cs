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
        var len = nums.Length;
        
        // [-1, -1, 0, -3, 3]
        prefix[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            prefix[i] = prefix[i - 1] * nums[i - 1]; // look left for value 
        }
        suffix[nums.Length - 1] = 1;
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
        prefix[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            prefix[i] = prefix[i - 1] * nums[i - 1]; // look left for value 
        }
        var suffix = 1;
        answer[nums.Length - 1] = prefix[nums.Length -1];    
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            //  0,1,2,3
            // [1,2,3,4]
            // i = 2
            // answer[3] = 6
            // suffix = 1
            // nums[i]= 3
            // nums[i + 1] = 4
            // answer[3] = 8
            answer[i] = (suffix * nums[i + 1]) * prefix[i];
            suffix = suffix * nums[i + 1];
            // i = 2
            // prefix[2] = 2
            // suffx = 
            // answer[3] = 4
        }

        return answer;
    }

    public static int[] PrefixProductOnlyTake2(int[] nums)
    {
        var answer = new int[nums.Length];
        var prefix = new int[nums.Length];

        // [-1, -1, 0, -3, 3]
        prefix[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            prefix[i] = prefix[i - 1] * nums[i - 1]; // look left for value 
        }
        var suffix = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            answer[i] = (suffix) * prefix[i];
            suffix = suffix * nums[i];
        }

        return answer;
    }
}
