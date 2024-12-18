using Blind75LeetCode.Services.Arrays._05_MaxSubArray;
using Shouldly;

namespace Blind75LeetCode.UnitTests.Arrays._05_MaxSubArray;

public class MaxSubArrayTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void OptimisedTests(int[] nums, int answer)
    {
        // Arrange
        // Act
        var result = MaxSubArrayService.Optimised(nums);

        // Assert
        result.ShouldBe(answer);
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void BruteForceTests(int[] nums, int answer)
    {
        // Arrange
        // Act
        var result = MaxSubArrayService.BruteForce(nums);

        // Assert
        result.ShouldBe(answer);
    }

    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6 },
            new object[] { new int[] { 2, 3, -8, 7, -1, 2, 3 }, 11 },
            new object[] { new int[] { -2, -4 }, -2 },
            new object[] { new int[] { 5, 4, 1, 7, 8 }, 25 },
        };
}


