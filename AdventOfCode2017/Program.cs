using System;
using System.Diagnostics;
using AdventOfCode2017.Day1;
using AdventOfCode2017.Day2;

namespace AdvdentOfCode2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Day1 Answer: {InverseCaptcha.CalcSum()}");
            Console.WriteLine($"Day1 Part2 Answer: {InverseCaptcha.CalcSumPart2()}");

            var day2InputPuzzle = System.IO.File.ReadAllText("Day2\\InputPuzzleDay2.txt");
            Console.WriteLine($"Day2 Answer: {CorruptionChecksum.CalculateCheckSum(day2InputPuzzle)}");
            Console.WriteLine($"Day1 Part2 Answer: {CorruptionChecksum.CalculateCheckSum_Part2(day2InputPuzzle)}");


            if (Debugger.IsAttached)
            {
                Console.ReadKey();
            }
        }
    }
}
