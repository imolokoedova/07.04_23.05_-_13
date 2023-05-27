﻿// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);
Console.WriteLine();
double[] calcAverageInColumn = CalcAverageInColumn(array2d);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(calcAverageInColumn);

// метод1
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

// метод 2

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}


// метод3

double[] CalcAverageInColumn(int[,] matrix)
{
    double[] arr = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        double average = sum / matrix.GetLength(0);
        arr[j] = average;
    }
    return arr;
}

// метод4

void PrintArray (double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double round = Math.Round(arr[i], 1, MidpointRounding.ToZero);

        if (i < arr.Length - 1)
        Console.Write($"{round}, ");

        else
        Console.WriteLine($"{round}");
    }
}
