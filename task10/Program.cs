// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int WriteSecondDigit(int num)
{
    return (num % 100);
}

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && <= 999) ;
{
    int result WriteSecondDigit(int num);
    Console.WriteLine(result);
}

else
{
    Console.WriteLine("Вы ввели не трехзначное число.");
}