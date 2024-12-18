using Blind75LeetCode.Services.Arrays._05_MaxSubArray;
using Blind75LeetCode.Services.Arrays._06_MaximumProductSubarray;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75LeetCode.UnitTests.Arrays._06_MaximumProductSubarray;
public class MaximumProductSubarrayTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void BruteForceTests(int[] nums, int answer)
    {
        // Arrange
        // Act
        var result = MaximumProductSubarrayService.BruteForce(nums);

        // Assert
        result.ShouldBe(answer);
    }

    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new int[] { 1, 2, 3, 4 }, 24 },
            new object[] { new int[] { -1, -2, -3, -4, -5 }, 120 }
        };
}
