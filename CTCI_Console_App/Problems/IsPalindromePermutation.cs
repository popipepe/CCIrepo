using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    public partial class Problem
    {
        public void IsPalindromePermutation()
        {
            String Word = getString();

            bool answer = mIsPalindromePermutation(Word);

            Console.WriteLine("Can what you wrote be a palindrome? -" + answer);
            FinishProblem();
        }
        public bool mIsPalindromePermutation(String W)
        {
            int[] table = createTable(W);
            return checkTable(table);
        }
        private int getCharNumber(char c)
        {
            int a = Convert.ToInt32('a');
            int z = Convert.ToInt32('z');
            int val = Convert.ToInt32(c);
            if(a <= val && val <= z)
            {
                return val - a;
            }
            return -1;
        }
        
        private int[] createTable(String strIn)
        {
            int[] table = new int[getCharNumber('z') - getCharNumber('a') + 1];

            foreach(char c in strIn.ToCharArray())
            {
                int index = getCharNumber(c);
                if(index != -1)
                {
                    table[index]++;
                }
            }
            return table;
        }
        private bool checkTable(int[] table)
        {
            bool odd = false;
            foreach(int I in table)
            {
                if(I % 2 != 0)
                {
                    if(odd)
                    {
                        return false;
                    }
                    odd = true;
                }
            }
            return true;
        }
    }
}
