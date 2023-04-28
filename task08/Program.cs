// Напишите программу, которая на вход принимает число N, а на выходе показывает все четныеы числа от 1 до N.
// 5 -> 2,4
// 8 -> 2,4,6,8

Console.WriteLine("Введите любое натуральное число:");
int numberA = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= numberA)
{

    if (count % 2 == 0)
    {
        Console.Write(count + " ");
    }

    count++;
}

if (numberA < 1)
    {
        Console.WriteLine("Натуральное число - целое положительное число больше нуля.");
    }
