int num1 = ReadInt("Введите порядковый номер дня недели:");

Weekend(num1);

// Является ли этот день выходным?
void Weekend(int number1)
{
    string[] arrey1 = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
    if (number1/6>0)
    {
        Console.WriteLine("ДА :) " + number1 + "-й день недели - это " + arrey1[number1-1] + ".");
    }
    else
    {
        Console.WriteLine("НЕТ :( " + number1 + "-й день недели - это " + arrey1[number1-1] + ".");
    }
}

// Ввод
int ReadInt(string massege)
{
    Console.Write(massege);
    return Convert.ToInt32(Console.ReadLine());
}

