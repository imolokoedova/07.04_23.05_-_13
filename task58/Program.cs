// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] matrix1 = CreateMatrixRndInt(4, 3, -10, 10);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrixRndInt(2, 3, -10, 10);
PrintMatrix(matrix2);
Console.WriteLine();
if (matrix1.GetLength(1) != matrix2.GetLength(0))
Console.WriteLine ("Матрицы не перемножаемы.");
return;
int[,] rezultMatrix = MultiplyMatrix(matrix1, matrix2);
PrintMatrix(rezultMatrix);


// метод 1

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

// метод 3

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] rezultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < rezultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < rezultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            rezultMatrix[i, j] = sum;
        }
    }
    return rezultMatrix;
}