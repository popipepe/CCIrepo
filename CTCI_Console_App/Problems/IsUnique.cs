using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    public partial class Problem
    {
        private void IsUnique()
        {
            Console.WriteLine("--Write anything--");
            String isuniqueword = getString();

            bool answer = mIsUnique(isuniqueword);

            Console.WriteLine("Is word made of unique characters? -" + answer);
            FinishProblem();

        }
        private bool mIsUnique(String uWord)
        {
            if(uWord.Length > 256)
            {
                return false;
            }
            bool[] allChars = new bool[256];

            for (int intChar = 0; intChar < uWord.Length; intChar++)
            {
                if(allChars[uWord[intChar]] == true)
                {
                    return false;
                }
                else
                {
                    allChars[uWord[intChar]] = true;
                }
            }
            return true;
        }
    }
}
