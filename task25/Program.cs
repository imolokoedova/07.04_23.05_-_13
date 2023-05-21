// Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("Введите число А: ");
double numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 0)
{
    Console.WriteLine ("Вы ввели отрицательное число B. Число B должно быть положительным.");
    return;
}


double raiseToPower = RaiseToPower (numberA, numberB);
Console.WriteLine (raiseToPower);


// метод

double RaiseToPower(double numA, int numB)
{
    double result = 1;
    for (int i = 0; i < numB; i++)
    {
        checked
        {
            result *= numA;
        }

    }
    return result;

}