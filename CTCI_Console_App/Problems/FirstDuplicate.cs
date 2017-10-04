using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    public partial class Problem
    {
        private void FirstDuplicate()
        {
            Console.WriteLine("--All numbers to check for multiples separated by a space--");
            String numbers = getString();
            String[] number = numbers.Split(' ');
            int[] a = new int[number.Length];
            int index = 0;
            foreach(string x in number)
            {
                a[index] = int.Parse(x);
                index++;
            }

            int answer = mFirstDuplicate(a);

            Console.WriteLine("First duplicate is (-1 if none): " + answer);
            FinishProblem();
        }
        private int mFirstDuplicate(int[] numbers)
        {
            Dictionary<int, int> table = new Dictionary<int, int>();
            for(int index = 0; index<numbers.Length;index++)
            {
                int iNumber = numbers[index];
                if (!table.ContainsKey(iNumber))
                {
                    table.Add(iNumber, iNumber);
                }
                else
                {
                    return index;
                }
            }
            return -1;
        }
    }
}
