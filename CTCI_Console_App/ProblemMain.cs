using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    public partial class Problem
    {
        public probType type;

        public Problem(probType type_I)
        {
            type = type_I;
        }
        public void Solution()
        {
            //Case calling the correct method from to solve the specific problem
            if(type == probType.Z_Error_Not_Defined)
            {
                Console.WriteLine("Error Select a diferent problem");
            }
            else if (type == probType.IsUnique)
            {
                this.IsUnique();
            }
        }
    }
}
