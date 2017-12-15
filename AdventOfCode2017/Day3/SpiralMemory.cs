using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2017.Day3
{
    public class SpiralMemory
    {
        public static int CalculateSteps(int number)
        {
            return 0;
        }

        public static int FindLowerSquareRoot(int number)
        {
            for (int i = number - 1; i >= 0; i--)
            {
                var result =  Math.Sqrt(number);

                if((result % 2) == 0)
                {
                    return i;
                }
            }

            throw new Exception("Square Root Not Found");
        }

        public static int FindHigherSquareRoot(int number)
        {
            for (int i = 0; i < number; i++)
            {
                var result = Math.Sqrt(number);

                if ((result % 2) == 0)
                {
                    return i;
                }
            }

            throw new Exception("Square Root Not Found");
        }
    }
}
