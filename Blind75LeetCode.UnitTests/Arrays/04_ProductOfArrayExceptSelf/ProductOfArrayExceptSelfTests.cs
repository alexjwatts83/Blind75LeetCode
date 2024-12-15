using Blind75LeetCode.Services.Arrays._04_ProductOfArrayExceptSelf;
using Shouldly;

namespace Blind75LeetCode.UnitTests.Arrays._04_ProductOfArrayExceptSelf;

public class ProductOfArrayExceptSelfTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void UseDivisionTests(int[] nums, int[] answer)
    {
        // Arrange
        // Act
        var result = ProductOfArrayExceptSelfService.UseDivision(nums);

        // Assert
        result.ShouldBe(answer);
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void PrefixAndSufficProductTests(int[] nums, int[] answer)
    {
        // Arrange
        // Act
        var result = ProductOfArrayExceptSelfService.PrefixAndSufficProduct(nums);

        // Assert
        result.ShouldBe(answer);
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void BruteForceTests(int[] nums, int[] answer)
    {
        // Arrange
        // Act
        var result = ProductOfArrayExceptSelfService.BruteForce(nums);

        // Assert
        result.ShouldBe(answer);
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void PrefixProductOnlyTests(int[] nums, int[] answer)
    {
        // Arrange
        // Act
        var result = ProductOfArrayExceptSelfService.PrefixProductOnly(nums);

        // Assert
        result.ShouldBe(answer);
    }


    [Theory]
    [MemberData(nameof(Data))]
    public void PrefixProductOnlyTake2Tests(int[] nums, int[] answer)
    {
        // Arrange
        // Act
        var result = ProductOfArrayExceptSelfService.PrefixProductOnlyTake2(nums);

        // Assert
        result.ShouldBe(answer);
    }

    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 } },
            new object[] { new int[] { -1, 1, 0, -3, 3 }, new int[] { 0, 0, 9, 0, 0 } },
            new object[] { new int[] { 10, 3, 5, 6, 2 }, new int[] { 180, 600, 360, 300, 900} },
            new object[] { new int[] { 1, 2, 3, 4, 5 }, new int[] { 120, 60, 40, 30, 24 } },
            new object[] { new int[] { 1, 4, 6, 2, 3 }, new int[] { 144, 36, 24, 72, 48 } },
        };
}
