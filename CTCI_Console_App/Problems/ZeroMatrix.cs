using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    public partial class Problem
    {
        private void ZeroMatrix()
        {
            Console.WriteLine("--Problem Started (no input)--");

            int[][] FirstMatrix = new int[5][];
            FirstMatrix[0] = new int[] { 1, 2, 3, 4, 5 };
            FirstMatrix[1] = new int[] { 6, 7, 8, 0, 10 };
            FirstMatrix[2] = new int[] { 11, 12, 13, 14, 15 };
            FirstMatrix[3] = new int[] { 16, 17, 18, 19, 20 };
            FirstMatrix[4] = new int[] { 21, 22, 23, 24, 0 };

            int[][] SecondMatrix = new int[4][];
            SecondMatrix[0] = new int[] { 1, 2, 3, 4, 20};
            SecondMatrix[1] = new int[] { 6, 7, 8, 9, 20};
            SecondMatrix[2] = new int[] { 0, 12, 13, 14, 20 };
            SecondMatrix[3] = new int[] { 16, 17, 18, 19, 0 };

            for (int i = 0; i < FirstMatrix.Length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < FirstMatrix[i].Length; j++)
                {
                    Console.Write(FirstMatrix[i][j] + " ");
                }
            }
            for (int i = 0; i < SecondMatrix.Length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < SecondMatrix[i].Length; j++)
                {
                    Console.Write(SecondMatrix[i][j] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Solution: ");
            Console.WriteLine();
            mZeroMatrix(FirstMatrix, SecondMatrix);
            FinishProblem();

        }
        private void mZeroMatrix(int[][] firstMatrix, int[][] secondMatrix)
        {
            int[][] solution;
            computeZero(firstMatrix, out solution);
            showMatrix(solution);
            Console.WriteLine();
            computeZero(secondMatrix, out solution);
            showMatrix(solution);
            Console.WriteLine();
        }
        private void computeZero(int[][] matrix, out int[][] solution)
        {
            List<Tuple<int, int>> locations = new List<Tuple<int, int>>();

            for(int row = 0; row < matrix.Length; row = row + 1)
            {
                for(int column = 0; column < matrix[row].Length; column = column + 1)
                {
                    if(matrix[row][column] == 0)
                    {
                        Tuple<int, int> loc = new Tuple<int, int>(row, column);
                        locations.Add(loc);
                    }
                }
            }
            for (int i = 0; i < locations.Count; i++)
            {
                for(int y = 0; y < matrix[locations[i].Item1].Length; y++)
                {
                    matrix[locations[i].Item1][y] = 0;
                }
                for (int x = 0; x < matrix.Length; x++)
                {
                    matrix[x][locations[i].Item2] = 0;
                }
            }
                solution = matrix;
        }
    }
}
