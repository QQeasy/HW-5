/*
Задача 10: Напишите программу, которая принимает 
на вход трёхзначное число и на выходе показывает
 вторую цифру этого числа.
*/ 
Console.WriteLine("Введите трехзначное число:");
int num1 = Convert.ToInt32(Console.ReadLine());
SecondNum(num1);

void SecondNum(int number1)
{
    if (number1/100>=1 && number1/100<=9)
    {
        int result = number1%100/10;
        Console.WriteLine("Число " + result + " - разряд десятков числа " + num1);
    }
    else
    {
        Console.WriteLine("Число " + num1 + " не является трехзначным!");
    }
}