// Задайте массив из вещественных чисел.
// Найдите разницу между max и min элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] array = CreateArrayRndDouble(5, 0.5, 500.5);
PrintArray(array);
double findMax = FindMax(array);
double findMin = FindMin(array);
Console.WriteLine(Math.Round(findMax - findMin, 1, MidpointRounding.ToZero));


// метод 1

double[] CreateArrayRndDouble(int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

// метод 2

void PrintArray(double[] arr)
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

// метод 3

double FindMax(double[] arr)
{
    double maxElem = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxElem)
        {
            maxElem = arr[i];

        }
    }
    return maxElem;
}

double FindMin(double[] arr)
{
    double minElem = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minElem)
        {
            minElem = arr[i];
        }
    } 
    return minElem;
}

