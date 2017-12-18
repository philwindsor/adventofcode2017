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
            var sqRtSequenceNumber = OddNumberOrder(sqrt); // vertical steps
            //var median = 
            //var horizontalSteps = StepsAwayFromMedian(number, median);

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
            if( (number % 2) == 0)
            {
                throw new ArgumentException("Number provided is not an odd number");
            }

            int num = 0;
            for (int i = 1; i <= number; i += 2)
            {
                num++;
            }

            return num;
        }

        public static (int start,int end) FindGridRange(int number, int sqrt, int sequnce)
        {
            
        }

        public static int FindMedian(int start, int end)
        {
            decimal count = 0;
            for (int i = start; i <= end; i++)
            {
                count++;
            }
            
            var result = Math.Round(count / 2m, 0, MidpointRounding.AwayFromZero);
            return start + (int)result-1;
        }

        public static int StepsAwayFromMedian(int number, int median)
        {
            return median - number;
        }
    }
}