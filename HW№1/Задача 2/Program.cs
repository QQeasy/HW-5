/*
Задача 4: Напишите программу, которая принимает на 
вход три числа и выдаёт максимальное из этих чисел.
*/ 
Console.WriteLine("Введите три числа:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int maximum = num1;
if (maximum < num2)
{
    maximum = num2;
}
else if ((maximum < num3))
{
    maximum = num3;
}   
Console.WriteLine(maximum);