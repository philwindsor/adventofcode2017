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
        [InlineData(8, 9)]
        [InlineData(20, 25)]
        [InlineData(9, 9)]
        [InlineData(25, 25)]
        public void FindSquareRoot_Should_Return_Correct_Number(int num, int expected)
        {
            SpiralMemory.FindSquareRoot(num).Should().Be(expected);
        }

        [Theory]
        [InlineData(9, 5)]
        [InlineData(25, 13)]
        [InlineData(1, 1)]
        [InlineData(5, 3)]
        public void OddNumberOrder_Should_Return_Correct_Number(int num, int expected)
        {
            SpiralMemory.OddNumberOrder(num).Should().Be(expected);
        }

        [Theory]
        [InlineData(7, 9, 8)]
        [InlineData(5, 7, 6)]
        [InlineData(21, 25, 23)]
        [InlineData(9, 13, 11)]
        public void FindMediun_Should_Return_Correct_Number(int start, int end, int expected)
        {
            SpiralMemory.FindMedian(start, end).Should().Be(expected);
        }
    }
}
