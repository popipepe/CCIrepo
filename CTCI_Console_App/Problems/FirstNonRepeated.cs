using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    public partial class Problem
    {
        private void FirstNonDuplicate()
        {
            Console.WriteLine("--String to check for first non duplicate char--");
            String word = getString();


            char answer = mFirstNonDuplicate(word);

            Console.WriteLine("First non Duplicated char is (_ if none): " + answer);
            FinishProblem();
        }
        private char mFirstNonDuplicate(String word)
        {
            Dictionary<char, bool> table = new Dictionary<char, bool>();
            foreach(char c in word)
            {
                if(!table.ContainsKey(c))
                {
                    table.Add(c, true);
                }
                else
                {
                    table[c] = false;
                }
            }
            foreach(char c in word)
            {
                if(table[c] == true)
                {
                    return c;
                }
            }
            return '_';
        }
    }
}
