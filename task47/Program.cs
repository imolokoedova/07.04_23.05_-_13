// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5     7     -2     -0,2
//  1    -3,3     8     -9,9
//  8     7,8   -7,1      9

Console.WriteLine("Введите количество строк в массиве:");
Console.Write("m = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:");
Console.Write("n = ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] matrix = CreateMatrixRndInt(rows, columns, -10, 10);
Console.WriteLine($"m = {rows}, n = {columns}");
Console.WriteLine();
PrintMatrix(matrix);

// метод1
double[,] CreateMatrixRndInt(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return matrix;
}

// метод 2

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double round = Math.Round(matrix[i, j], 1, MidpointRounding.ToZero);
            Console.Write($"{round,8}");
        }
        Console.WriteLine();
    }
}