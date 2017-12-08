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

            Console.WriteLine($"Day2 Answer: {CorruptionChecksum.CalculateCheckSum(System.IO.File.ReadAllText("Day2\\InputPuzzleDay2.txt"))}");
            //Console.WriteLine($"Day1 Part2 Answer: {InverseCaptcha.CalcSumPart2()}");


            if (Debugger.IsAttached)
            {
                Console.ReadKey();
            }
        }
    }
}
