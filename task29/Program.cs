// Напишите программу, которая задает массив из 8 элементов, заполненный псевдослучайными числами 
// и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] array = CreateArray (8);
PrintArray (array);
Console.Write ("-> [ ");
PrintArray (array);
Console.Write ("]");


int[] CreateArray (int size)
{
    int[] arr = new int [size];
    Random random = new Random ();
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next (0, 100);
    }
    return arr;
}

// метод 2

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write ($"{arr[i]} ");
    }
}
