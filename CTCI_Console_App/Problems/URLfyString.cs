using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    public partial class Problem
    {
        private void URLfyString()
        {
            Console.WriteLine("--Frase To URLfy--");
            String toURL = getString();

            String answer = mURLfyString(toURL);

            Console.WriteLine("Your Url Is: " + answer);
            FinishProblem();
        }
        private string mURLfyString (String strToURL)
        {
            String url = "";
            for (int ch = strToURL.Length - 1; ch > -1; ch--)
            {
                char c = strToURL[ch];
                if (c == ' ')
                {
                    url = "%20" + url;
                }
                else
                {
                    url = c + url;
                }
            }

            return url;
        }
        private int countWhites(String IN)
        {
            int OUT = 0;
            foreach(char c in IN.ToCharArray())
            {
                if(c == ' ')
                {
                    OUT++;
                }
            }
            return OUT;
        }
    }
}
