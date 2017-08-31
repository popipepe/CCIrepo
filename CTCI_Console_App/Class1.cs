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
            String isuniqueword = getUniqueWord();

            bool answer = mIsUnique(isuniqueword);

            Console.WriteLine(answer);
            Console.ReadLine();

        }
        private String getUniqueWord()
        {
            Console.WriteLine("Write a word please");
            String word = Console.ReadLine();

            return word;
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
