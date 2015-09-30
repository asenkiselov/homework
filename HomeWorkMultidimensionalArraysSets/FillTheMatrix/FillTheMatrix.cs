using System;

class FillMatrix
{
    static int n = 0;
    static void fillMatrixA()
    {
        int count = 1;
        int[,] matrixA = new int[n, n];
        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < n; cols++)
            {
                matrixA[cols, rows] = count++;
            }
        }
        PrintMatrix(matrixA);
    }
    static void fillMatrixB()
    {
        int[,] matrixB = new int[n, n];
        int count = 1;
        for (int rows = 0; rows < n; rows++)
        {
            if (rows % 2 == 0)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    matrixB[cols, rows] = count++;
                }
            }
            else
            {
                for (int cols = n - 1; cols >= 0; cols--)
                {
                    matrixB[cols, rows] = count++;
                }
            }
        }
        PrintMatrix(matrixB);
    }
    
    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("|{0,2}|", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
         n = 4;
        fillMatrixA();
        Console.WriteLine();
        fillMatrixB();

    }
}