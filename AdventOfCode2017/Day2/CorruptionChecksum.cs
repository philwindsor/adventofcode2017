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

        public static int CalculateCheckSum_Part2(string input)
        {
            var divisilbeSums = new List<int>();
            var lineBreaks = new string[] { "\r\n", "\r", "\n" };
            var colBreaks = new string[] { "\t", " " };
            foreach (var row in input.Split(lineBreaks, StringSplitOptions.RemoveEmptyEntries))
            {
                var cols = row.Split(colBreaks, StringSplitOptions.RemoveEmptyEntries);

                var rowParsed = new int[cols.Length];

                for (int i = 0; i < cols.Length; i++)
                {
                    rowParsed[i] = int.Parse(cols[i]);
                }                

                for (int i = 0; i < rowParsed.Length; i++)
                {
                    for (int j = 0; j < rowParsed.Length; j++)
                    {
                        if (i == j)
                        {
                            continue;
                        }
                        else
                        {
                            if( (rowParsed[i] % rowParsed[j]) == 0)
                            {
                                divisilbeSums.Add(rowParsed[i] > rowParsed[j] ? rowParsed[i] / rowParsed[j] : rowParsed[j] / rowParsed[i]);
                                
                                //exit loops
                                j = rowParsed.Length + 1;
                                i = rowParsed.Length + 1;
                            }
                        }
                    }
                }               
            }

            return divisilbeSums.Sum();
        }
    }
}
