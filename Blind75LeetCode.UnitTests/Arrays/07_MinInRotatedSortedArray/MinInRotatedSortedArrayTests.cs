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

    [Theory]
    [MemberData(nameof(Data))]
    public void OptimisedTests(int[] nums, int answer)
    {
        // Arrange
        // Act
        var result = MinInRotatedSortedArrayService.Optimised(nums);

        // Assert
        result.ShouldBe(answer);
    }

    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new int[] { 6, 7, 8, 9, 0, 1, 2, 3, 4, 5 }, 0 },
            new object[] { new int[] { 8, 9, 0, 1, 2, 3, 4, 5, 6, 7 }, 0 },
            new object[] { new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 0, 1 }, 0 },
            new object[] { new int[] { 3, 4, 1, 2 }, 1 },
            new object[] { new int[] { 2, 3, 4, 1 }, 1 },
            new object[] { new int[] { 6, 7, 8, 9, 0, 1 }, 0 },
            new object[] { new int[] { 3, 4, 5, 6, 1 }, 1 },
            new object[] { new int[] { 2, 1 }, 1 },
            new object[] { new int[] { 1 }, 1 },
        };
}
