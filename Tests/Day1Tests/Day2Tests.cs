using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using AdventOfCode2017.Day2;

namespace AdventOfCodeTests
{
    public class Day2Tests
    {
        [Fact]
        public void Example()
        {
            var input = "5  1   9   5\r\n" +
                        "7  5   3\r\n" +
                        "2  4   6   8";

            CorruptionChecksum.CalculateCheckSum(input).Should().Be(18);
        }

        [Fact]
        public void Example_Part2()
        {
            var input = "5\t9\t2\t8\r\n" +
                        "9\t4\t7\t3\r\n" +
                        "3\t8\t6\t5";

            CorruptionChecksum.CalculateCheckSum_Part2(input).Should().Be(9);
        }
    }
}
