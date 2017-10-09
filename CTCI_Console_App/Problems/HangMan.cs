using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    public partial class Problem
    {
        private void HangMan()
        {
            Console.WriteLine("Player 1 Write Secret Word");
            String Str = "";
            Boolean asd = true;
            while (asd)
            {
                char s = Console.ReadKey(true).KeyChar;
                if (s == '\r')
                {
                    asd = false;
                }
                else
                {
                    Str = Str + s.ToString();
                }
            }
            mHangMan(Str);
        }
        private void mHangMan(String hangManWord)
        {
            bool end = false;
            int numToRip = 6;
            bool[] used = new bool[255];
            String showL = "";
            foreach (char c in hangManWord)
            {

                if (used[c] == true)
                {
                    showL = showL + c;
                }
                else
                {
                    showL = showL + "_";
                }
            }

            Console.WriteLine(showL);

            while (!end)
            {
                bool valid = false;
                Console.WriteLine("Player 2 Write Letter:");
                char letter = Console.ReadLine()[0];
                valid = !used[letter];
                while (!valid)
                {
                    Console.WriteLine("Player 2 Write a Valid Letter:");
                    letter = Console.ReadLine()[0];
                    valid = !used[letter];

                }

                if(!hangManWord.Contains(letter))
                {
                    numToRip--;
                }
                used[letter] = true;
                String sToSHow = "";
                foreach(char c in hangManWord)
                {
                    
                    if(used[c] == true)
                    {
                        sToSHow = sToSHow + c;
                    }
                    else
                    {
                        sToSHow = sToSHow + "_";
                    }
                }
                if(numToRip == 0 || sToSHow == hangManWord)
                {
                    end = true;
                }
                DeadCowboy(numToRip);
                Console.WriteLine("Word so far: " + sToSHow);
            }
            if (numToRip == 0)
                Console.WriteLine("Word was: " + hangManWord);
            if(numToRip != 0)
                Console.WriteLine("Congratulations Player 2");
        }
        private void DeadCowboy(int numToRip)
        {
            if(numToRip == 0)
            {
            Console.WriteLine("|------|");
            Console.WriteLine("|     ( )");
            Console.WriteLine("|     -|-");
            Console.WriteLine(@"|     / \");
            Console.WriteLine("|");
            Console.WriteLine("|______");
            Console.WriteLine("Rip Player 2");
            }
            else if (numToRip == 1)
            {
                Console.WriteLine("|------|");
                Console.WriteLine("|     ( )");
                Console.WriteLine("|     -|-");
                Console.WriteLine(@"|     / ");
                Console.WriteLine("|");
                Console.WriteLine("|______");
            }
            else if (numToRip == 2)
            {
                Console.WriteLine("|------|");
                Console.WriteLine("|     ( )");
                Console.WriteLine("|     -|-");
                Console.WriteLine(@"|     ");
                Console.WriteLine("|");
                Console.WriteLine("|______");
            }
            else if (numToRip == 3)
            {
                Console.WriteLine("|------|");
                Console.WriteLine("|     ( )");
                Console.WriteLine("|     -|");
                Console.WriteLine(@"|     ");
                Console.WriteLine("|");
                Console.WriteLine("|______");
            }
            else if (numToRip == 4)
            {
                Console.WriteLine("|------|");
                Console.WriteLine("|     ( )");
                Console.WriteLine("|      |");
                Console.WriteLine(@"|     ");
                Console.WriteLine("|");
                Console.WriteLine("|______");
            }
            else if (numToRip == 5)
            {
                Console.WriteLine("|------|");
                Console.WriteLine("|     ( )");
                Console.WriteLine("|     ");
                Console.WriteLine(@"|     ");
                Console.WriteLine("|");
                Console.WriteLine("|______");
            }
            else if (numToRip == 6)
            {
                Console.WriteLine("|------|");
                Console.WriteLine("|     ");
                Console.WriteLine("|     ");
                Console.WriteLine(@"|     ");
                Console.WriteLine("|");
                Console.WriteLine("|______");
            }
        }
       
    }
}
