using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    public partial class Problem
    {
        public void FinishProblem()
        {
            Console.WriteLine("--------- ^^ SOLUTION DONE ^^ ---------");
            Console.WriteLine();
            Console.WriteLine("PRESS ANY BUTTON TO CONTINUE");
            Console.ReadLine();
        }
        private String getString()
        {
            Console.WriteLine("Press enter when writen");
            String word = Console.ReadLine();

            return word;
        }
    }
}
