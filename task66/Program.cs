// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.


// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое положительное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM < 0 | numberN < 0) CheckNumberIsNatural(numberM, numberN);
else
{
    Console.Write($"M = {numberM}; N = {numberN} -> ");
    if (numberM < numberN)
        Console.Write(GetSumOfInterval(numberM, numberN));
    else
        Console.Write(GetSumOfIntervalBackwards(numberM, numberN));
}



// метод 1

int GetSumOfInterval(int numM, int numN)
{
    if (numM == numN) return numN;
    else return numM + GetSumOfInterval(numM + 1, numN);
}

// метод 2

int GetSumOfIntervalBackwards(int numM, int numN)
{
    if (numM == numN) return numN;
    else return numM + GetSumOfIntervalBackwards(numM - 1, numN);
}

// метод 3

void CheckNumberIsNatural(int numM, int numN)
{
    if (numM < 0 && numN < 0)
        Console.WriteLine("Вы ввели отрицательные числа М и N. Введите целые положительные значения для M и N.");
    else if (numN < 0)
        Console.WriteLine("Вы ввели отрицательное число N. Введите целое положительное число N.");
    else if (numM < 0)
        Console.WriteLine("Вы ввели отрицательное число M. Введите целое положительное число M.");
}








// void CheckNumberIsNatural(int numM, int numN)
// {
//     if (numM < 0)
//         Console.WriteLine("Вы ввели отрицательное число M. Введите целое положительное число M.");
//     else if (numN < 0)
//         Console.WriteLine("Вы ввели отрицательное число N. Введите целое положительное число N.");
//     else if (numM < 0 && numN < 0)
//         Console.WriteLine("Вы ввели отрицательные числа М и N. Введите целые положительные значения для M и N.");
// }




