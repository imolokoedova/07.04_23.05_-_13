// Напишите программу, которая на вход принимает одно число (N), а навыходе показывает все целые числа от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

Console.WriteLine("Введите числа:");
int i = Convert.ToInt32(Console.ReadLine());
int count = -i;
while (count<=i)
{
    Console.Write(count + " ");
    count ++;
}
