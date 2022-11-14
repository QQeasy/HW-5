/* Задача 27: Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/
SummNum();

//Выводит сумму чисел, составляющих число
void SummNum()
{
    int Num1 = ReadInt("Введите число, состав цифр которого хотите просуммировать: ");
    int SumNum = 0;
    int Num = Num1;
    while (Num>1)
    {
        int IntermediateNum = Num%10;
        SumNum += IntermediateNum;
        Num = Num/10;
    }
    Console.Write("Сумма цифр в числе " + Num1 + " равна " + SumNum);
}


// Ввод
int ReadInt(string massege)
{
    Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}