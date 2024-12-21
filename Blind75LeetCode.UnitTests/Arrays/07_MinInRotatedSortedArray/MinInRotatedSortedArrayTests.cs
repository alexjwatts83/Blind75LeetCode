using Blind75LeetCode.Services.Arrays._07_MinInRotatedSortedArray;
using Shouldly;

namespace Blind75LeetCode.UnitTests.Arrays._07_MinInRotatedSortedArray;
public class MinInRotatedSortedArrayTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void BruteForceTests(int[] nums, int answer)
    {
        // Arrange
        // Act
        var result = MinInRotatedSortedArrayService.BruteForce(nums);

        // Assert
        result.ShouldBe(answer);
    }

    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new int[] { 6, 7, 8, 9, 0, 1, 2, 3, 4, 5 }, 0 },
        };
}
