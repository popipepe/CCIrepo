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
            else if ( type == probType.IsPermutation)
            {
                this.IsPermutation();
            }
            else if ( type == probType.IsPalindromePermutation)
            {
                this.IsPalindromePermutation();
            }
            else if( type == probType.URLfy)
            {
                this.URLfyString();
            }
            else if ( type == probType.OneAway)
            {
                this.OneAway();
            }
            else if (type == probType.DateToFormat)
            {
                this.DateToFormat();
            }
            else if (type == probType.FirstDuplicate)
            {
                this.FirstDuplicate();
            }
            else if (type == probType.FirstNonRepeated)
            {
                this.FirstNonDuplicate();
            }
            else if (type == probType.ConsecutiveDistanceRating)
            {
                this.ConsecutiveDistanceRating();
            }
            else if (type == probType.HangMan)
            {
                this.HangMan();
            }
            else if (type == probType.SecretCodes)
            {
                this.SecetCodes();
            }
            else if (type == probType.Tally)
            {
                this.Tally();
            }
            else if (type == probType.CompressWord)
            {
                this.CompressWord();
            }
        }
    }
}
