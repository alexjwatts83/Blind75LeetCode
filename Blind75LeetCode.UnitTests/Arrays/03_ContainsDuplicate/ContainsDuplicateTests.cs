using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blind75LeetCode.UnitTests.Arrays._03_ContainsDuplicate;

public class ContainsDuplicateTests
{
    [Fact]
    public void BruteForceTests()
    {

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
