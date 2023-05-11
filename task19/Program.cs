// Напишите программу, которая принимает на вход пятизначное число и проверяет является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да




bool IsPalindrome(int num)
{
    int num1 = (num % 100000) / 10000;
    int num2 = (num % 10000) / 1000;
    int num4 = (num % 100) / 10;
    int num5 = num % 10;
    return num1 == num5 && num2 == num4;
}



Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number = number * -1;
}
if (number < 10000 || number > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число.");
}
else
{
    bool result = IsPalindrome(number);
    Console.WriteLine(result ? "да" : "нет");
}


