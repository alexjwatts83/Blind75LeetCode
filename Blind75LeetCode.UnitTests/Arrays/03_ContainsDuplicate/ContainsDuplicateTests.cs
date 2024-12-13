using Blind75LeetCode.Services.Arrays._03_ContainsDuplicate;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75LeetCode.UnitTests.Arrays._03_ContainsDuplicate;

public class ContainsDuplicateTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void BruteForceTests(int[] nums, bool answer)
    {
        // Arrange
        // Act
        var result = ContainsDuplicateService.BruteForce(nums);

        // Assert
        result.ShouldBe(answer);
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void OptimisedTests(int[] nums, bool answer)
    {
        // Arrange
        // Act
        var result = ContainsDuplicateService.Optimised(nums);

        // Assert
        result.ShouldBe(answer);
    }

    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new int[] { 1, 2, 1, 2, 3 }, true },
            new object[] { new int[] { 1, 2, 3, 1 }, true },
            new object[] { new int[] { 1, 1, 1, 3, 3, 4 }, true },
            new object[] { new int[] { 1, 3, 4, 2 }, false },
        };
}
