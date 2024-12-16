using Blind75LeetCode.Services.Arrays._04_ProductOfArrayExceptSelf;
using Blind75LeetCode.Services.Arrays._05_MaxSubArray;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75LeetCode.UnitTests.Arrays._05_MaxSubArray;

public class MaxSubArrayTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void BruteForceTests(int[] nums, int[] answer)
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
            new object[] { new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 } },
        };
}


