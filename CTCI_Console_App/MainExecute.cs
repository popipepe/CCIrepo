using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    class MainExecute
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                RunProblems();
                Console.WriteLine("Continue with more problems? y/n");
                String info = Console.ReadLine();
                if (info == "n")
                {
                    continuar = false;
                }

            }

        }
        public static void RunProblems()
        {
            Console.WriteLine("Please write the number of the problem you want");
            int problem;
            String[] problems = Enum.GetNames(typeof(probType));
            for (int number = 1; number < problems.Length; number++)
            {
                Console.WriteLine((number) + "- " + problems[number]);
            }

            Problem DoThis;
            bool good = int.TryParse(Console.ReadLine(), out problem);
            if (!good)
            {
                DoThis = new Problem(probType.Z_Error_Not_Defined);
            }
            else
            {
                String name = Enum.GetName(typeof(probType), problem);
                probType type = (probType)Enum.Parse(typeof(probType), name);
                DoThis = new Problem(type);
            }

            DoThis.Solution();
        }
    }
}
