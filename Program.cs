using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 2, 4, 5 },
            { 3, 5, 6 }
        };

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        bool isSymmetricMain = IsSymmetricMain(matrix);
        if (isSymmetricMain)
        {
            Console.WriteLine("Матрица симметрична относительно главной диагонали.");
        }
        else
        {
            Console.WriteLine("Матрица не симметрична относительно главной диагонали.");
        }

        bool isSymmetricSecondary = IsSymmetricSecond(matrix);
        if (isSymmetricSecondary)
        {
            Console.WriteLine("Матрица симметрична относительно побочной диагонали.");
        }
        else
        {
            Console.WriteLine("Матрица не симметрична относительно побочной диагонали.");
        }

        Console.ReadLine();
    }

    static bool IsSymmetricMain(int[,] matrix)
    {
        int size = matrix.GetLength(0);

        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (matrix[i, j] != matrix[j, i])
                {
                    return false;
                }
            }
        }

        return true;
    }

    static bool IsSymmetricSecond(int[,] matrix)
    {
        int size = matrix.GetLength(0);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size - i - 1; j++)
            {
                if (matrix[i, j] != matrix[size - j - 1, size - i - 1])
                {
                    return false;
                }
            }
        }

        return true;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int size = matrix.GetLength(0);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}