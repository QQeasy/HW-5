/* Задача 27: Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

PowMath();
void PowMath()
{
    int Num1 = ReadInt("Введите число, которое хотите возвести в степень: ");
    int degree = ReadInt("Введите степень: ");
    int N1 = Num1;
    for (int i=1; i<=degree-1; i++)
    {
        N1 *= Num1;
    }
    Console.WriteLine("Число "+ Num1 + " в степени " + degree + " - это "+ N1);
}


// Ввод
int ReadInt(string massege)
{
    Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}