// Задайте массив, заполненный случайными положительными трехзначными числами. 
// Напишите программу, которая покажет количество четных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = CreateArrayRndInt (5, 100, 1000);
PrintArray (array);
int findAmmountOfEvens = FindAmmountOfEvens (array);
Console.Write ($" -> {findAmmountOfEvens}");



// метод 1

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] arr = new int [size];
    Random rnd = new Random();
    
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next (min, max+1);
    }
    return arr;
}

// метод 2

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        Console.Write ($"{arr[i]}, ");
        else
        Console.WriteLine ($"{arr[i]}");
    }
}

// метод 3

int FindAmmountOfEvens (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0)
        count ++;
    }
    return count;
}