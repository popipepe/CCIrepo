using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    public partial class Problem
    {
        private void IsRotation()
        {
            Console.WriteLine("--Write word one--");
            String strWord = getString();
            Console.WriteLine("--Write word to compare if its a rotation--");
            String strWordToCheck = getString();

            Console.WriteLine("Is it a rotation? -" + mIsRotation(strWord, strWordToCheck));
            FinishProblem();

        }
        private bool mIsRotation(String original, String check)
        {
            bool answer = false;
            original = original + original;

            int index = original.IndexOf(check);

            if(index != -1)
            {
                answer = true;
            }

            return answer;
        }
    }
}
