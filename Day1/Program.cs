using System;
using System.Diagnostics;
using AdventOfCode2017.Day1;

namespace AdvdentOfCode2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Day1 Answer: {InverseCaptcha.CalcSum()}");
            Console.WriteLine($"Day1 Part2 Answer: {InverseCaptcha.CalcSumPart2()}");

            if (Debugger.IsAttached)
            {
                Console.ReadKey();
            }
        }
    }
}
