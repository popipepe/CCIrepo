using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    public partial class Problem
    {
        private void CompressWord()
        {
            Console.WriteLine("--Write anything--");
            String strWordToCheck = getString();

            Console.WriteLine("The compressed word is: " + mStringCompression(strWordToCheck));
            FinishProblem();

        }
        private String mStringCompression(String compWord)
        {
            String answer = "";
            List<String> toWord = new List<String>();
            int total = 0;
            char lastLetter = compWord[0];
            
            foreach(char count in compWord)
            {   
                if(count != lastLetter)
                {
                    toWord.Add(lastLetter.ToString());
                    toWord.Add(total.ToString());
                    lastLetter = count;
                    total = 0;
                }

                total = total + 1;
            }
            string possible = string.Concat(toWord);

            if(possible.Length >= compWord.Length)
            {
                answer = compWord;
            }
            else
            {
                answer = possible;
            }

            return answer;
        }
    }
}
