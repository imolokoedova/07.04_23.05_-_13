// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет


Console.WriteLine("Введите позицию элемента в двумерном массиве");
Console.WriteLine("Номер ряда:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Номер колонки:");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateMatrixRndInt(3, 4, -10, 10);
if (!(row <= matrix.GetLength(0) && column <= matrix.GetLength(1)
    && row > 0 && column > 0))
    {
        Console.WriteLine($"{row}, {column} -> такого элемента в массиве нет");
        return;
    }   
PrintMatrix(matrix);
int getElement = GetElement(matrix, row, column);
Console.WriteLine(getElement);



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



int GetElement(int[,] matrix, int row, int column)
{
    return (matrix[row - 1, column - 1]);
}


/* int FindElement(int[,] matrix, int row, int column)
{
    if (i == row && j == column)
    return matrix[row, column];
}
*/