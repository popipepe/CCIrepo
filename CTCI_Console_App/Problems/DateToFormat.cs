using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    public partial class Problem
    {
        private void DateToFormat()
        {
            Console.WriteLine("--Date (In any DD MM YYYY format)--");
            String date = getString();
            Console.WriteLine("--Format of Date (In UpperCase)--");
            String dateFormat = getString();
            Console.WriteLine("--Format wanted (In UpperCase)--");
            String dateWanted = getString();


            String answer = mDateToFormat(date, dateFormat, dateWanted);

            Console.WriteLine("Formated Date: " + answer);
            FinishProblem();
        }
        private string mDateToFormat(String date, String current, String wanted)
        {
            int day, month, year;

            day = current.IndexOf('D');
            month = current.IndexOf('M');
            year = current.IndexOf('Y');

            String sday, smonth, syear;

            sday = date.Substring(day, 2);
            smonth = date.Substring(month, 2);
            syear = date.Substring(year, 4);

            wanted = wanted.Replace("DD", sday).Replace("MM", smonth).Replace("YYYY", syear);

            return wanted;
        }
    }
}
