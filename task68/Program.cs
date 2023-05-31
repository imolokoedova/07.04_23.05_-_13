// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Функция Аккермана определяется рекурсивно для неотрицательных целых чисел m и n следующим образом:

// Akkerman    n + 1                       m = 0;
//             A(m -1, 1)                  m > 0; n = 0;
//             A(m - 1, A(m, n - 1));      m > 0; n > 0;

Console.WriteLine("Введите целое положительное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"m = {numberM}, n = {numberN} -> A(m,n) = {CountAckermanFunction(numberM, numberN)}");

int CountAckermanFunction(int numM, int numN)
{
    if (numM == 0)
        return numN + 1;
    else if (numN == 0)
        return CountAckermanFunction(numM - 1, 1);
    else
        return CountAckermanFunction(numM - 1, CountAckermanFunction(numM, numN - 1));
}