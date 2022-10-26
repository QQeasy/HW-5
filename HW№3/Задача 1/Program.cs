/*
Задача 19.
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом. (Использовать только математические 
операции, нельзя использовать число как строку по типу number[1])
*/ 
int num1 = ReadInt("Введите число:");

Palindrome(num1);


// Проверим, является ли число палиндромом
void Palindrome(int number1)
{
    int FirstNum = number1/10000;
    int SecondNum = number1/1000%10;
    int FirstLastNum = number1%10;
    int SecondLastNum = number1%100/10;
    if (FirstNum==FirstLastNum && SecondNum==SecondLastNum)
    {
        Console.Write("Число " + number1 + " является палиндромом.");
    }
    else 
    {
        Console.Write("Число " + number1 + " не является палиндромом.");
    }
}



// Ввод
int ReadInt(string massege)
{
    Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}
