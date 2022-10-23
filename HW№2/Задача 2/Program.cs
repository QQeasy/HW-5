/*
Задача 13: Напишите программу, которая 
выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.
*/ 
int num1 = ReadInt("Введите число:");

ThirdNumber(num1);

// Нахождение третьего числа
void ThirdNumber(int number1)
{
    if (number1>=100)
    {
        while (number1 > 1000) //поиск первых трех чисел
        {
            number1 = number1/10 ;
        }
        int result = number1%10;
        Console.WriteLine(result + " - третья цифра числа " + num1);

    }
    else
    {
        Console.WriteLine("Число " + number1 + " не имеет третьего числа!");
    }
}

// Ввод
int ReadInt(string massege)
{
    Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}
