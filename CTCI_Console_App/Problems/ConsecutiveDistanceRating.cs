using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    public partial class Problem
    {
        private void ConsecutiveDistanceRating()
        {
            String[] Numbers = getFileToArrayInProjectHome();
            int[] totals = mConsecutiveDistanceRating(Numbers);
            foreach(int toWrite in totals)
            {
                Console.WriteLine(toWrite);
            }

        }
        private int[] mConsecutiveDistanceRating(String[] numbers)
        {
            int problems;
            int numbersPerLine;
            firstLine(numbers[0], out problems, out numbersPerLine);
            int[] sumOfRating = new int[problems];

            for (int index = 0; index < problems; index++)
            {
                int[] numbersToRating = parseLine(numbers[index + 1], numbersPerLine);
                sumOfRating[index] = eachLine(numbersToRating);
            }

            return sumOfRating;
        }
        private void firstLine(String firstLine, out int problems, out int numbersPerLine)
        {
            String[] twoNum = firstLine.Split(' ');
            problems = int.Parse(twoNum[0]);
            numbersPerLine = int.Parse(twoNum[1]);
        }
        private int eachLine(int[] line)
        {
            int Rating = 0;
            Dictionary<int, int> table = new Dictionary<int,int>();
            for (int index = 0; index < line.Length; index++)
            {
                bool before = false;
                bool after = false;
                int beforeN = line[index]-1;
                int afterN = line[index]+1;
                if(table.ContainsKey(beforeN))
                {
                    before = true;
                    Rating = Math.Abs(table[beforeN] - index) + Rating;
                }

                if (table.ContainsKey(afterN))
                {
                    after = true;
                    Rating = Math.Abs(table[afterN] - index) + Rating;
                }

                if(!before || !after)
                {
                    table.Add(beforeN + 1, index);
                }
            }

                return Rating;
        }
        private int[] parseLine(String line, int total)
        {
            String[] allNum = line.Split(' ');
            int[] lineNum = new int[total];
            for (int index = 0; index < total; index++)
            {
                lineNum[index] = int.Parse(allNum[index]);
            }
            return lineNum;
        }

    }
}
