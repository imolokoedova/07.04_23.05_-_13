// Напишите программу, которая принимает на вход координаты 2-х точек и находит расстояние между ними в 3D пространстве.
// A(3,6,8); B(2,1,-7) -> 15.84
// A(7,-5,0); B(1,-1,9) -> 11.53

//метод

double DistanceAB(int Xa, int Ya, int Za, int Xb, int Yb, int Zb)
{
    int deltaX = Xa - Xb;
    int deltaY = Ya - Yb;
    int deltaZ = Za - Zb;
    double distAB = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    return distAB;
}

Console.WriteLine("Введите координаты точки А");
Console.Write("Xa:");
int xACoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Ya:");
int yACoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Za:");
int zACoordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("Xb:");
int xBCoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Yb:");
int yBCoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Zb:");
int zBCoordinate = Convert.ToInt32(Console.ReadLine());

double distanceAB = DistanceAB (xACoordinate, yACoordinate, zACoordinate, xBCoordinate, yBCoordinate, zBCoordinate);
double distRound = Math.Round (distanceAB, 2, MidpointRounding.ToZero);

Console.WriteLine (distRound);


// Console.WriteLine ($"{xACoordinate} {yACoordinate} {zACoordinate}");
//Console.Write ($"{xBCoordinate} {yBCoordinate} {zBCoordinate}");



