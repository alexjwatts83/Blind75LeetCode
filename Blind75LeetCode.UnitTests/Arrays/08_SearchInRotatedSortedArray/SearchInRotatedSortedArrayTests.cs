using Blind75LeetCode.Services.Arrays._08_SearchInRotatedSortedArray;
using Shouldly;

namespace Blind75LeetCode.UnitTests.Arrays._08_SearchInRotatedSortedArray;
public class SearchInRotatedSortedArrayTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void BruteForceTests(int[] nums, int target, int answer)
    {
        // Arrange
        // Act
        var result = SearchInRotatedSortedArrayService.BruteForce(nums, target);

        // Assert
        result.ShouldBe(answer);
    }

    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4 },
            new object[] { new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1 },
            new object[] { new int[] { 1 }, 0, -1 },
        };
}
