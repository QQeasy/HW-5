/*
Задача 23

Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int N = ReadInt("Введите число, до которого хотите вывести таблицу кубов:");
Console.WriteLine("Таблица кубов от 1 до "+ N +":");
Console.WriteLine();
CubeTable(N);

// Выводит табилцу кубов до N-го числа
void CubeTable(int Number1)
{
    for (int i = 1; i<=Number1; i++)
    {
    double Cube = Math.Pow(i,3);
    Console.WriteLine(i + "^3 = " + Cube);   
    }
}

// Ввод
int ReadInt(string massege)
{
    Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}