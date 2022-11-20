/*

Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным 
значениями элементов массива.
[3 7 22 2 78] -> 76


*/
int size = ReadInt("Введите число элементов массива: ");

int[] arrey = new int[size];


ArreyAdd(size);
Console.WriteLine();

Console.WriteLine("Ваш новый случайный массив: ");

ArreyPrint(arrey);
Console.WriteLine();

ArreySumOddNum(arrey);


Console.WriteLine();



//Задаёт массив из N чисел

int[] ArreyAdd(int N)
{
    for (int i = 0; i < N; i++)
    {
        arrey[i] = new Random().Next(-100,100);
    }
    return arrey;
}


// Выводит массив
void ArreyPrint(int[] arrey1)
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
void ArreySumOddNum(int[] arrey2)
{
    int Sum1 = 0;
    for (int i = 1; i < arrey2.Length; i+=2)
    {
       Sum1 += arrey2[i];
    }
    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + Sum1);
}

// Ввод
int ReadInt(string massege)
{
    Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}