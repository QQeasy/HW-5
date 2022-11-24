/*

Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным 
значениями элементов массива.
[3 7 22 2 78] -> 76
int

*/
int size = ReadDouble("Введите число элементов массива: ");

double[] arrey = new double[size];
double MaxNArrey = 0;
double MinNArrey = 0;

ArreyAdd(size);
Console.WriteLine();

Console.WriteLine("Ваш новый случайный массив: ");

ArreyPrint(arrey);
Console.WriteLine();

MaxArreyN(arrey, MaxNArrey);
Console.WriteLine("Максимальный элемент массива: " + MaxNArrey);
Console.WriteLine();

MinArreyN(arrey, MinNArrey);
Console.WriteLine("Минимальный элемент массива: " + MinNArrey);
Console.WriteLine();



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
double MaxArreyN(double[] arrey3, double MaxNumArrey = arrey3[0])
{
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
double MinArreyN(double[] arrey4, double MinNumArrey = arrey4[0])
{
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
double DiffMinMaxN(double MinNum, double MaxNum, double DiffN )
{
    DiffN = MaxNum - MinNum;
    return DiffN;
    
}
// Ввод
int ReadDouble(string massege)
{
    Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}