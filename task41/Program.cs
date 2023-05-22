// Пользователь вводит с клавиатуры М чисел.
// Посчитайте сколко чисел больше нуля ввел пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3


Console.WriteLine("Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
int countPositive = CountPositive(array);
Console.WriteLine ($" -> {countPositive}");


// метод 1

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    for (int i = 1; i < size - 1; i++)
    {
        Console.WriteLine($"Введите {i} число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}


// метод 2

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
}

// метод 3

int CountPositive(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count++;
    }
    return count;
}
