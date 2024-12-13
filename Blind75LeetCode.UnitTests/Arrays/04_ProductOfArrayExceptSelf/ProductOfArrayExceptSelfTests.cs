using Blind75LeetCode.Services.Arrays._04_ProductOfArrayExceptSelf;
using Shouldly;

namespace Blind75LeetCode.UnitTests.Arrays._04_ProductOfArrayExceptSelf;

public class ProductOfArrayExceptSelfTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void OptimisedSortedTests(int[] nums, int[] answer)
    {
        // Arrange
        // Act
        var result = ProductOfArrayExceptSelfService.BruteForce(nums);

        // Assert
        result.ShouldBe(answer);
    }

    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 } },
            new object[] { new int[] { -1, -1, 0, -3, 3 }, new int[] { 0, 0, 9, 0, 0 } },
        };
}
