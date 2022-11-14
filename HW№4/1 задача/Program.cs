/* Задача 25:Напишите цикл, который принимает 
на вход два числа (A и B) и возводит число A 
в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

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