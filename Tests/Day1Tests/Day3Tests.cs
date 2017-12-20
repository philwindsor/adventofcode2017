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
            SpiralMemory.FindSquareRoot(num).value.Should().Be(expected);
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
        [InlineData(0)]
        [InlineData(2)]
        [InlineData(20)]
        [InlineData(2000)]
        public void OddNumberOrder_Should_Throw_Error_When_Even_Number_Supplied(int even)
        {
            Action a = () => SpiralMemory.OddNumberOrder(even);

            a.ShouldThrowExactly<ArgumentException>();
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

        [Theory]
        [InlineData(1, 0)]
        [InlineData(12, 3)]
        [InlineData(23, 2)]
        [InlineData(1024, 31)]
        public void CalculateSteps_Should_Return_Correct_Step_Count(int number, int steps)
        {
            SpiralMemory.CalculateSteps(number).Should().Be(steps);
        }

        [Theory]
        [InlineData(8, 9, 2, 7, 9)] // First grid after 1
        [InlineData(6, 9, 2, 5, 7)]
        [InlineData(4, 9, 2, 3, 5)]
        [InlineData(2, 9, 2, 1, 3)]
        [InlineData(23, 25, 3, 21, 25)] // second grid after 1
        [InlineData(19, 25, 3, 17, 21)]
        [InlineData(15, 25, 3, 13, 17)]
        [InlineData(11, 25, 3, 9,13)]       

        public void FindGridRange_Should_Return_Correct_Range(int number, int sqrt, int sequnce, int start, int end)
        {
            var result = SpiralMemory.FindGridRange(number, sqrt, sequnce);

            result.start.Should().Be(start);
            result.end.Should().Be(end);
        }
    }
}
