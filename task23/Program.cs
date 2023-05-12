// Напишите программу, которая принимает на вход число N и выдает таблицу кубов всех чисел от 1 до N.
// 3 -> 1, 8, 27;
// 5 -> 1, 8, 27, 64, 125;

// метод TableAllCubes

void TableAllCubes(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count, 3} {count * count * count, 5}");
        count++;
    }
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
TableAllCubes(number);


