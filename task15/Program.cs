// Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool IsDayOff(int num)
{
    return (num == 6 || num == 7 ? true : false);
}

Console.WriteLine("Введите цифру, обозначающую день недели:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
    Console.WriteLine("В неделе вообще-то семь дней.");
else
    Console.WriteLine(IsDayOff(number) ? "да" : "нет");






