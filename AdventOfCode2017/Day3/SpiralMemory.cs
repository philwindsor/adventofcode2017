using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2017.Day3
{
    public class SpiralMemory
    {
        public static int CalculateSteps(int number)
        {
            var sqrt = FindSquareRoot(number);




            return 0;
        }

        public static int FindSquareRoot(int number)
        {
            for (int i = number; i < int.MaxValue; i++)
            {
                var result = Math.Sqrt(i);

                if ((result % 1) == 0)
                {
                    return i;
                }
            }

            throw new Exception("Square Root Not Found");
        }

        public static int OddNumberOrder(int number)
        {           
            int num = 0;
            for (int i = 1; i <= number; i += 2)
            {
                num++;
            }

            return num;
        }

        public static int FindMedian(int start, int end)
        {
            return (int)Enumerable.Range(start, end).Average();           
        }
    }
}