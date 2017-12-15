using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using AdventOfCode2017.Day3;

namespace AdventOfCodeTests
{
    public class Day3Tests
    {
        [Theory]
        [InlineData(10, 9)]
        public void FindLowerSquareRoot_Should_Return_Correct_Number(int num, int expected)
        {
            SpiralMemory.FindLowerSquareRoot(num).Should().Be(expected);
        }
    }
}
