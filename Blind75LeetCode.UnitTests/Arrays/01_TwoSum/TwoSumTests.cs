using Blind75LeetCode.Services.Arrays._01_TwoSum;
using Shouldly;

namespace Blind75LeetCode.UnitTests.Arrays._01_TwoSum;

public class TwoSumTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void OptimizedTests(int[] nums, int target, int[] answer)
    {
        // Arrange
        // Act
        var result = TwoSumService.Optimized(nums, target);

        // Assert
        result.ShouldBe(answer);
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void BruteForceTest(int[] nums, int target, int[] answer)
    {
        // Arrange
        // Act
        var result = TwoSumService.BruteForce(nums, target);

        // TODO: update to accomodate 

        // Assert
        result.ShouldBe(answer);
    }

    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new int[] { 2, 1, 3, 5, 8 }, 9, new int[] { 1, 4 } },
            new object[] { new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 } },
            new object[] { new int[] { -1, -2, -3, -4, -5 }, -8, new int[] { 2, 4 } },
            //new object[] { new int[] { 10, 15, 20, 25, 30 }, 45, new int[] { 2, 3} },
            // whilst 15 + 30 = 45, 20 and 25, are interated over first and equal 45 as well
        };
}
