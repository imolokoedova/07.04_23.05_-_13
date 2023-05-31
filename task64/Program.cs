// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 0) 
Console.WriteLine("Вы ввели отрицательное число. Введите целое положительное число.");
else
{
    Console.Write($"{number} -> ");
    GetNumbersOfInterval(number);
}



// метод

void GetNumbersOfInterval(int num)
{
    if (num == 0) return;
    Console.Write (num);
    GetNumbersOfInterval(num - 1);
}



