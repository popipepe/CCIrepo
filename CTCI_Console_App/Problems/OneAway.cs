using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    public partial class Problem
    {
        private void OneAway()
        {
            String word1 = getString(); 
            String word2 = getString();

            bool answer = mOneAway(word1, word2);

            Console.WriteLine("Is your word1 one change away from word2? -" + answer);
            FinishProblem();
        }
        private bool mOneAway(String check, String vs)
        {
            int chl = check.Length;
            int vsl = vs.Length;
            int chequedl = Math.Abs(chl - vsl);

            if(chequedl > 1)
            {
                return false;
            }

            int[] table = new int[265];
            foreach(char c in check.ToCharArray())
            {
                table[c]++;
            }
            bool foundL = false;
            bool foundC = false;
            if(chequedl == 1)
            {
                foundL = true;
            }

            for (int i = 0; i < vs.Length; i++)
            {
                table[vs[i]]--;
                if (foundL && foundC && table[vs[i]] < 0)
                {
                    return false;
                }
                if(table[vs[i]] == -1)
                {
                    foundC = true;
                }
                
            }

            return true;
        }
    }
}
