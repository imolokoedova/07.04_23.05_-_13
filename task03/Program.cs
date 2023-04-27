// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> среда
// 5 -> пятница

Console.WriteLine("Введите число от 1 до 7:");
int i = Convert.ToInt32(Console.ReadLine());

if (i == 1)
{
    Console.WriteLine ("понедельник");
}
else if (i == 2)
{
    Console.WriteLine ("вторник");
}
else if (i == 3)
{
    Console.WriteLine ("среда");
}
else if (i == 4)
{
    Console.WriteLine ("четверг");
}
else if (i == 5)
{
    Console.WriteLine ("пятница");
}
else if (i == 6)
{
    Console.WriteLine ("суббота");
}
else if (i == 7)
{
    Console.WriteLine ("воскресенье");
}
else 
{
    Console.WriteLine ("ошибка");
}