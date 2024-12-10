using Blind75LeetCode.Services.Arrays._02_BestTimeToBuyAndSellStock;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75LeetCode.UnitTests.Arrays._02_BestTimeToBuyAndSellStock;

public class BestTimeToBuyAndSellStockTests
{
    [Fact]
    public void Optimised()
    {
        // Arrange
        var nums = new int[] { 7, 1, 5, 3, 6, 4 };
        var answer = 5;

        // Act
        var result = BestTimeToBuyAndSellStockService.Run(nums);

        // Assert
        result.ShouldBe(answer);
    }
}
