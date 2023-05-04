// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int WriteSecondDigit(int num)
{
    int first = num/100;
    int third = num%10;
    int result = (num - first*100 - third)/10;
    return (result);
}

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int result = WriteSecondDigit(number);
Console.WriteLine(number >= 100 && number <= 999 ? result : "Вы ввели не трехзначное число.");

