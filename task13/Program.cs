// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


//метод
int GetThirdDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}




Console.WriteLine("Введите любое число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    int result = GetThirdDigit(number);
    Console.WriteLine ($"Третье число:{result}");
}







