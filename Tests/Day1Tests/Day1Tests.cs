using System;
using AdventOfCode2017.Day1;
using FluentAssertions;
using Xunit;

namespace Day1Tests
{
    public class Day1Tests
    {
        // http://adventofcode.com/2017/day/1#
        [Theory]
        [InlineData("1122", 3)]
        [InlineData("1111", 4)]
        [InlineData("1234", 0)]
        [InlineData("91212129", 9)]
        public void Examples(string input, long expected)
        {
            InverseCaptcha.CalcSum(input).Should().Be(expected);
        }

        [Theory]
        [InlineData("1212", 6)]
        [InlineData("1221", 0)]
        [InlineData("123425", 4)]
        [InlineData("123123", 12)]
        [InlineData("12131415", 4)]
        public void ExamplesPart2(string input, long expected)
        {
            InverseCaptcha.CalcSumPart2(input).Should().Be(expected);
        }
    }
}