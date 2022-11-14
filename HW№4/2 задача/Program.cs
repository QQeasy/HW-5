/* Задача 27: Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/
int Num1 = ReadInt("Введите число, состав цифр которого хотите просуммировать: ");
SummNum(Num1);

//Выводит сумму чисел, составляющих число
int SummNum(int Num);
{
   
    while (Num>=10)
    {
        int NUM = Num%10;
        Num = Num/10;
        int QuantityNum = QuantityNum + NUM;
        Console.Write("Сумма цифр в числе " + Num1 + " равна " + QuantityNum);
    }
}


// Ввод
int ReadInt(string massege)
{
    Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}