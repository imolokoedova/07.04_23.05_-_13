// Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями:
// y = k1*x + b1;
// y = k2*x + b2;
// Значения b1, k1, b2 и k2 задаются пользователем.

// 1. находим из данных уравнений точку x
// 2. обрабатываем ввод данных.
// 3. метод для нахождения x
// 4. метод для нахождения y
// 5. округление в методе с делением используем, double тип

// k1*x + b1 = k2*x + b2
// k1*x - k2*x = b2 - b1
// x*(k1 - k2) = b2 - b1
// x = (b2 - b1)/(k1 - k2)

Console.WriteLine("Задайте значение для b1: ");
double numberB1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте значение для k1: ");
double numberK1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте значение для b2: ");
double numberB2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте значение для k2: ");
double numberK2 = Convert.ToDouble(Console.ReadLine());

if (numberK1 == numberK2 && numberB1 == numberB2)
    Console.WriteLine("Прямые совпадают.");
else if (numberK1 == numberK2)
    Console.WriteLine("Прямые параллельны.");

else
{
    double findXCoordinate = FindXCoordinate(numberB1, numberB2, numberK1, numberK2);
    double findYCoordinate = FindYCoordinate(findXCoordinate, numberB1, numberK1);
    double roundXCoordinate = Math.Round(findXCoordinate, 1, MidpointRounding.ToZero);
    double roundYCoordinate = Math.Round(findYCoordinate, 1, MidpointRounding.ToZero);
    Console.WriteLine($"Координаты точки пересечения прямых ({roundXCoordinate}, {roundYCoordinate})");
}




// метод1

double FindXCoordinate(double numB1, double numB2, double numK1, double numK2)
{
    double xCoordinate = (numB2 - numB1) / (numK1 - numK2);
    return xCoordinate;
}


// метод2

double FindYCoordinate(double xCoordinate, double numB1, double numK1)
{
    double yCoordinate = numK1 * xCoordinate + numB1;
    return yCoordinate;
}

