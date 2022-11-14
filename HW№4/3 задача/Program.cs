/* Задача 29: Напишите программу, которая задаёт 
массив из N элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */
ArreyNum();

//Выводит случайные числа массива размера N на экран
void ArreyNum()
{
    int N = ReadInt("Введите N - число элементов массива: ");

    Console.WriteLine("Ваш новый случайный массив из N элементов: ");

    Console.Write("[ ");

    int[] arrey = new int[N];
    for (int i = 0; i < N; i++)
    {
        arrey[i] = new Random().Next(1,20);
        Console.Write(arrey[i] + " ");
    }
    Console.Write("]");
}


// Ввод
int ReadInt(string massege)
{
    Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}