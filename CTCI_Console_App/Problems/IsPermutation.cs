using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    public partial class Problem
    {
        public void IsPermutation()
        {
            Console.WriteLine("--Word 1--");
            String Word1 = getString();
            Console.WriteLine("--Word 2--");
            String Word2 = getString();

            bool answer = mIsPermutation(Word1, Word2);

            Console.WriteLine("Are Word1 and Word2 Permutations? -" + answer);
            FinishProblem();
        }
        public bool mIsPermutation(String W1, String W2)
        {
            if(W1.Length != W2.Length)
            {
                return false;
            }

            int[] chars = new int[256];

            for (int i = 0; i < W1.Length; i++)
            {
                chars[W1[i]] = chars[W1[i]] + 1;
            }
            for (int j = 0; j < W2.Length; j++)
            {
                chars[W2[j]] = chars[W2[j]] - 1;
                if(chars[W2[j]] < 0)
                {
                    return false;
                }
            }
            int check = chars.Max();
            if (check != 0)
                return false;


            return true;
        }
    }
}
