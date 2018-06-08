using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    public partial class Problem
    {
        private void SecetCodes()
        {
            Console.WriteLine("Enter input message (\"string\" (rows,columns) clockwise or counter-clockwise)");
            String input = getString();

            String output = mSecretCodes(input);

            Console.WriteLine("Your code is: " + output);
            FinishProblem();
        }
        private String mSecretCodes(String input_I)
        {
            //parse input, assuming its always correct formating
            int commas =  input_I.LastIndexOf('"');
            int parr = input_I.LastIndexOf(')');
            String message = input_I.Substring(1,commas - 1);
            String numbers = input_I.Substring(commas + 2, parr - (commas + 2));
            String direction = input_I.Substring(parr + 2);

            int columns, rows;

            //  take parentesis out
            numbers = numbers.Substring(1, numbers.Length - 1);
            //      parse to int.
            String[] toNumber = numbers.Split(',');

            columns = int.Parse(toNumber[1]);
            rows = int.Parse(toNumber[0]);

            String[,] arrtoCode = populateArrayToDisplay(columns, rows, message);

            return createStringToDisplay(arrtoCode, direction);
        }

        private String createStringToDisplay(String[,] arrtoCode_I, String direction_I)
        {
            String finalMessage = "";

            int maxX, minX, minY, maxY;
            maxX = arrtoCode_I.GetLength(1) - 1;
            maxY = arrtoCode_I.GetLength(0) - 1;
            minX = 0;
            minY = 0;

            int indexX = maxX;
            int indexY = 0;
            if (direction_I == "counter-clockwise")
            {
                while (maxX > minX && maxY > minY)
                {
                    while (indexX >= minX)
                    {
                        finalMessage = finalMessage + arrtoCode_I[indexY, indexX];
                        
                        indexX = indexX - 1;
                    }
                    indexX = minX;
                    minY = minY + 1;
                    indexY = minY;
                    while (indexY <= maxY)
                    {
                        finalMessage = finalMessage + arrtoCode_I[indexY, indexX];
                        
                        indexY = indexY + 1;
                    }
                    indexY = maxY;
                    minX = minX + 1;
                    indexX = minX;
                    while (indexX <= maxX)
                    {
                        finalMessage = finalMessage + arrtoCode_I[indexY, indexX];
                        
                        indexX = indexX + 1;
                    }
                    indexX = maxX;
                    maxY = maxY - 1;
                    indexY = maxY;
                    while (indexY >= minY)
                    {
                        finalMessage = finalMessage + arrtoCode_I[indexY, indexX];
                        
                        indexY = indexY - 1;
                    }
                    indexY = minY;
                    maxX = maxX - 1;
                    indexX = maxX;
                }
            }
            else if (direction_I == "clockwise")
            {
                while (maxX > minX && maxY > minY)
                {

                    while (indexY <= maxY)
                    {
                        finalMessage = finalMessage + arrtoCode_I[indexY, indexX];
                        
                        indexY = indexY + 1;
                    }
                    indexY = maxY;
                    maxX = maxX - 1;
                    indexX = maxX;
                    while (indexX >= minX)
                    {
                        finalMessage = finalMessage + arrtoCode_I[indexY, indexX];
                        
                        indexX = indexX - 1;
                    }
                    indexX = minX;
                    maxY = maxY - 1;
                    indexY = maxY;
                    while (indexY >= minY)
                    {
                        finalMessage = finalMessage + arrtoCode_I[indexY, indexX];
                        
                        indexY = indexY - 1;
                    }
                    indexY = minY;
                    minX = minX + 1;
                    indexX = minX;
                    while (indexX <= maxX)
                    {
                        finalMessage = finalMessage + arrtoCode_I[indexY, indexX];
                        
                        indexX = indexX + 1;
                    }
                    indexX = maxX;
                    minY = minY + 1;
                    indexY = minY;
                }
            }

            return finalMessage;

        }

        private String[,]populateArrayToDisplay(int columns_I, int rows_I, string message_I)
        {
            String[,] populated_O = new String[columns_I, rows_I];

            message_I = message_I.Replace(" ", "");
            message_I = message_I.Replace(".", "");
            message_I = message_I.Replace(",", "");
            message_I = message_I.Replace("/", "");
            message_I = message_I.Replace("\\", "");
            message_I = message_I.Replace("?", "");
            message_I = message_I.Replace("!", "");
            message_I = message_I.Replace("-", "");
            message_I = message_I.Replace("'", "");
            message_I = message_I.ToUpper();
            int total = rows_I * columns_I;
            if(total > message_I.Length)
            {
                for(int x = message_I.Length; x < total; x = x + 1)
                {
                    message_I = message_I + "X";
                }
            }

            Char[] characterized = message_I.ToCharArray();
            int whatCharr = 0;
            for(int y = 0; y < columns_I;  y = y + 1)
            {

                for (int x = 0; x < rows_I; x = x + 1)
                {
                    populated_O[y,x] = characterized[whatCharr].ToString();
                    whatCharr = whatCharr + 1;

                }
            }
            return populated_O;
        }
    }
}
