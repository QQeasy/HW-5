/*Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

**Cделать отдельные функции для заполнения и для вывода массива)
*/
int size = ReadInt("Введите число элементов массива: ");

int[] arrey = new int[size];

ArreyAdd(size);
Console.WriteLine();

Console.WriteLine("Ваш новый случайный массив: ");

ArreyPrint(arrey);
Console.WriteLine();

Console.WriteLine("Число четных чисел в массиве: ");

ArreySumDouble(arrey);
Console.WriteLine();





//Задаёт массив из N чисел

int[] ArreyAdd(int N)
{
    for (int i = 0; i < N; i++)
    {
        arrey[i] = new Random().Next(100,1000);
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


// Ввод
int ReadInt(string massege)
{
    Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}