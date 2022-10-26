/*Задача 21

Напишите программу, которая принимает на вход координаты
двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

int X1 = ReadInt("Введите координату X1:");
int X2 = ReadInt("Введите координату X2:");
int Y1 = ReadInt("Введите координату Y1:");
int Y2 = ReadInt("Введите координату Y2:");
int Z1 = ReadInt("Введите координату Z1:");
int Z2 = ReadInt("Введите координату Z2:");

Length3D(X1, X2, Y1, Y2, Z1, Z2);

// Находит расстояние между точками в 3D пространстве
void Length3D(int X1, int X2, int Y1, int Y2, int Z1, int Z2)
{
    double X = Math.Pow((X2 - X1),2);
    double Y = Math.Pow((Y2 - Y1),2);
    double Z = Math.Pow((Z2 - Z1),2);
    double res = X + Y + Z;
    double Length = Math.Sqrt((res));
    Console.WriteLine(X +""+ Y+"" + Z);
    Console.Write(Length + " - это расстояние между указанными точками в 3D пространстве");
}

// Ввод
int ReadInt(string massege)
{
    Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}
