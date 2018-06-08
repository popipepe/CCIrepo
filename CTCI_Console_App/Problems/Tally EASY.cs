using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    public partial class Problem
    {
        private void Tally()
        {
            Console.WriteLine("Write the scores (each character is a player, lower case = +1, lower case = -1)");
            String input = getString();

            char[] charArr = input.ToCharArray();
            List<char> used = new List<char>();
            int[] intChars = new int[256];

            foreach(char x in charArr)
            {
                if(char.IsLower(x))
                {
                    if(!used.Contains(x))
                    {
                        used.Add(x);
                    }
                    intChars[x] = intChars[x] + 1;
                }
                else if(char.IsUpper(x))
                {
                    char original = x.ToString().ToLower()[0];
                    if (!used.Contains(original))
                    {
                        used.Add(original);
                    }

                    intChars[original] = intChars[original] - 1;
                }
            }

            foreach(char y in used)
            {
                if(y != 0)
                {
                    Console.WriteLine("Player {0} has {1} points", y, intChars[y]);
                }
            }
        }

    }
}
