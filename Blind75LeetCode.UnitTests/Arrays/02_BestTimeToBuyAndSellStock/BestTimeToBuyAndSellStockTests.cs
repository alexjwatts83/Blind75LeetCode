﻿using Blind75LeetCode.Services.Arrays._02_BestTimeToBuyAndSellStock;
using Shouldly;

namespace Blind75LeetCode.UnitTests.Arrays._02_BestTimeToBuyAndSellStock;

public class BestTimeToBuyAndSellStockTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void BruteForce(int[] nums, int answer)
    {
        // Arrange
        // Act
        var result = BestTimeToBuyAndSellStockService.BruteForce(nums);

        // Assert
        result.ShouldBe(answer);
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void Optimised(int[] nums, int answer)
    {
        // Arrange
        // Act
        var result = BestTimeToBuyAndSellStockService.Optimised(nums);

        // Assert
        result.ShouldBe(answer);
    }

    public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new int[] { 7, 1, 5, 3, 6, 4 }, 5 },
            new object[] { new int[] { 7, 6, 4, 3, 1 }, 0 },
        };
}
