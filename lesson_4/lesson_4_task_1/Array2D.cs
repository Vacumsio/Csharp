using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4_task_1
{
    class Array2D
    {
        int[,] matrix;
        Random r;
        const int matrixRows = 5;
        const int matrixCols = 5;

        public Array2D()
        {
            matrix = new int[matrixRows, matrixCols];
            r = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i,j] = r.Next(-10000, 10000);
                }
            }
        }

        public string Print2D()
        {
            string temp = String.Empty;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    temp += ($"{matrix[i,j]} ");
                }
                temp += "\n";
            }
            return temp;
        }
    }
}
