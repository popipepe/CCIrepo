using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_Console_App
{
    public partial class Problem
    {
        private void RotateMatrix()
        {
            Console.WriteLine("--Problem Started (no input)--");
            int[][] FirstMatrix = new int[5][];
            FirstMatrix[0] = new int[]{ 1, 2, 3, 4, 5 };
            FirstMatrix[1] = new int[]{ 6, 7, 8, 9, 10 };
            FirstMatrix[2] = new int[]{ 11, 12, 13, 14, 15 };
            FirstMatrix[3] = new int[]{ 16, 17, 18, 19, 20 };
            FirstMatrix[4] = new int[] { 21, 22, 23, 24, 25 };

            int[][] SecondMatrix = new int[4][];
            SecondMatrix[0] = new int[] { 1, 2, 3, 4 };
            SecondMatrix[1] = new int[] { 6, 7, 8, 9 };
            SecondMatrix[2] = new int[] { 11, 12, 13, 14 };
            SecondMatrix[3] = new int[] { 16, 17, 18, 19 };

            for (int i = 0; i < FirstMatrix.Length ; i++)
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
                mRotateMatrix(FirstMatrix, SecondMatrix);
            FinishProblem();

        }

        private void mRotateMatrix(int[][] firstMatrix, int[][] secondMatrix)
        {
            int[][] solution;
            computeRotation(firstMatrix, out solution);
            showMatrix(solution);
            Console.WriteLine();
            computeRotation(secondMatrix,out solution);
            showMatrix(solution);
            Console.WriteLine();
        }

        private void computeRotation(int[][] matrix, out int[][] solution)
        {
            int size = matrix.Length;
            for(int layer = 0; layer < size/2; layer = layer + 1)
            {
                int first = layer;
                int last = size - 1 - layer;
                
                for(int i = first; i < last; i++)
                {
                    int offset = i - first;

                    int top = matrix[first][i];

                    //left to top
                    matrix[first][i] = matrix[last - offset][first];

                    //bot to left
                    matrix[last-offset][first] = matrix[last][last - offset];

                    //right to bot
                    matrix[last][last - offset] = matrix[i][last];

                    //top to right
                    matrix[i][last] = top;
                }

            }


            solution = matrix;
        }

        private void showMatrix(int[][] solution)
        {
            for (int i = 0; i < solution.Length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < solution[i].Length; j++)
                {
                    Console.Write(solution[i][j] + " ");
                }
            }
        }
    }
}
