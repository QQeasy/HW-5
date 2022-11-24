/*

Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным 
значениями элементов массива.
[3 7 22 2 78] -> 76

*/

int size = ReadDouble("Введите число элементов массива: ");


double[] arrey = new double[size];


ArreyAdd(size);                                                                                                     //Создаёт массив
Console.WriteLine();


Console.WriteLine("Ваш новый случайный массив: ");


ArreyPrint(arrey);                                                                                                  //Печать массива
Console.WriteLine();


double MaxNArrey = 1;
MaxNArrey = MaxArreyN(arrey, MaxNArrey);                                                                            //Поиск мах элемента
Console.WriteLine();
Console.WriteLine("Максимальный элемент массива: " + MaxNArrey);


double MinNArrey = 1;
MinNArrey = MinArreyN(arrey, MinNArrey);                                                                            //Поиск мин элемента
Console.WriteLine();
Console.WriteLine("Минимальный элемент массива: " + MinNArrey);


double DiffArreyNum = 0;                                                                                            //Поиск разности мах-мин элемента
DiffArreyNum = DiffMinMaxN(MaxNArrey,MinNArrey);
Console.WriteLine();
Console.WriteLine("Разность максимального и минимального элемента массива: " + DiffArreyNum);




//Задаёт массив из N чисел

double[] ArreyAdd(double N)
{
    for (int i = 0; i < N; i++)
    {
        arrey[i] = new Random().Next(-100,100);
    }
    return arrey;
}


// Выводит массив
void ArreyPrint(double[] arrey1)
{   Console.Write("[ ");
    for (int i = 0; i < arrey1.Length; i++)
    {
        Console.Write(arrey1[i] + " ");
    }
    Console.WriteLine("]");
}



// Считает к-во четных чисел в массиве
void ArreySumDouble(int[] arrey2)
{
    int SumArrey2 = 0;
    for (int i = 0; i < arrey2.Length; i++)
    {
        if (arrey2[i]%2==0)
        {
           SumArrey2 = SumArrey2 + 1;
        }
    }        
    Console.WriteLine(SumArrey2 + " - число четных чисел в массиве ");
}




// Суммирует все элементы массива, стоящие на нечётных позициях.
void ArreySumOddNum(double[] arrey2)
{
    double Sum1 = 0;
    for (int i = 1; i < arrey2.Length; i+=2)
    {
       Sum1 += arrey2[i];
    }
    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + Sum1);
}




// Поиск максимального значения в массиве
double MaxArreyN(double[] arrey3, double MaxNumArrey = 0)
{
    MaxNumArrey = arrey3[0];
    for (int i = 1; i<arrey3.Length; i++)
    {
        if (MaxNumArrey<arrey3[i])
        {
            MaxNumArrey = arrey3[i];
        }
    }
    return MaxNumArrey;
}




// Поиск минимального значения в массиве 
double MinArreyN(double[] arrey4, double MinNumArrey = 0)
{
    MinNumArrey = arrey4[0];
    for (int i = 1; i<arrey4.Length; i++)
    {
        if (MinNumArrey>arrey4[i])
        {
            MinNumArrey = arrey4[i];
        }
    }
    return MinNumArrey;
}




// Находит разность между максимальным и минимальным элементом массива
double DiffMinMaxN(double MaxNum, double MinNum)
{
    double DiffN = MaxNum - MinNum;
    return DiffN;
}



// Ввод
int ReadDouble(string massege)
{
    Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}