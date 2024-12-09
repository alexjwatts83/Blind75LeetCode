using Blind75LeetCode.Services.Arrays._01_TwoSum;
using Shouldly;

namespace Blind75LeetCode.UnitTests.Arrays._01_TwoSum;

public class TwoSumTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void Tests(int[] nums, int target, int[] answer)
    {
        // Arrange
        // Act
        var result = TwoSumService.TwoSum(nums, target);

        // Assert
        result.ShouldBe(answer);
    }

    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new int[] { 2, 1, 3, 5, 8 }, 9, new int[] { 1, 4 } },
            new object[] { new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 } },
            new object[] { new int[] { -1, -2, -3, -4, -5 }, -8, new int[] { 2, 4 } },
            new object[] { new int[] { 10, 15, 20, 25, 30 }, 45, new int[] { 1, 3} },
        };
}
