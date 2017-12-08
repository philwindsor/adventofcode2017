using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdventOfCode2017.Day2
{
    public class CorruptionChecksum
    {
        public static int CalculateCheckSum(string input)
        {
            var checkSums = new List<int>();
            var lineBreaks = new string[] { "\r\n", "\r", "\n" };
            var colBreaks = new string[] { "\t", " "};
            foreach (var row in input.Split(lineBreaks, StringSplitOptions.RemoveEmptyEntries))
            {
                var cols = row.Split(colBreaks, StringSplitOptions.RemoveEmptyEntries);

                int lowest = int.MaxValue, highest = int.MinValue;
                foreach (var col in cols)
                {
                    var num = int.Parse(col);

                    if (num < lowest)
                    {
                        lowest = num;
                    }

                    if (num > highest)
                    {
                        highest = num;
                    }
                }

                checkSums.Add(highest - lowest);
            }

            return checkSums.Sum();
        }
    }
}
