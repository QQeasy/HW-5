/* Задача 25:Напишите цикл, который принимает 
на вход два числа (A и B) и возводит число A 
в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

int Num1 = ReadInt("Введите число, которое хотите возвести в степень: ");
int degree = ReadInt("Введите степень: ");
double Num = Math.Pow(Num1,degree);
Console.WriteLine("Число "+ Num1 + " в степени " + degree + " это "+ Num);


// Ввод
int ReadInt(string massege)
{
    Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}