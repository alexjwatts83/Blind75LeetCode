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
        };
}
