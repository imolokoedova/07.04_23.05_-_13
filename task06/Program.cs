// Напишите программу, которая принимает на вход число и возвращает яыляется ли число четным.
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Введите число:");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA % 2 == 0)
{
    Console.WriteLine("да");
}
    
else
{
    Console.WriteLine("нет");
}
    
