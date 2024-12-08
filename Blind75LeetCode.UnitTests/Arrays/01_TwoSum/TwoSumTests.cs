using Blind75LeetCode.Services.Arrays._01_TwoSum;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75LeetCode.UnitTests.Arrays._01_TwoSum;

public class TwoSumTests
{
    [Fact]
    public void Tests()
    {
        // Arrange
        int[] nums = [2, 1, 3, 5, 8];
        int target = 9;

        // Act
        var result = TwoSumService.TwoSum(nums, target);

        // Assert
        result.ShouldBe([1, 4]);
    }
}
