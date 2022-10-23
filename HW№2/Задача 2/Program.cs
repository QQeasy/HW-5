/*
Задача 13: Напишите программу, которая 
выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.
*/ 
Console.WriteLine("Введите трехзначное число:");
int num1 = Convert.ToInt32(Console.ReadLine());
SecondNum(num1);

void SecondNum(int number1)
{
    if (number1/100>=1 && number1/100<=9)
    {
        int result = number1%10;
        Console.WriteLine("Число " + result + " - разряд единиц числа " + num1);
    }
    else
    {
        Console.WriteLine("Число " + num1 + " не является трехзначным!");
    }
}