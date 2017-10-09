using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        private String[] getFileToArrayInProjectHome()
        {
            Console.WriteLine("Write the name of the file to test");
            String path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
                @"\Desktop\CCI_Project_And_Tests\CCI\trunk\CTCI_Console_App\ProblemTestFiles";
            path = path + Console.ReadLine();
            string[] lines;
            List<String> listOfLines = new List<String>();
            var fileStream = new FileStream(@path, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    listOfLines.Add(line);
                }
            }
            return lines = listOfLines.ToArray();
        }
    }
}
