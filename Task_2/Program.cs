//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int InputInt(string message)
{
    System.Console.Write($"{message} -> ");
    int value;
    if (int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

int Counter(int number)
{
    int count = 0;
    if (number < 0) number = number * -1;
    while (number != 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

void Summator(int number, int longnumber)
{
    int num = number;
    int res = 0;
    int[] array = new int[longnumber];
    for (int i = 0; i < longnumber; i++)
    {
        array[i] = number % 10;
        number /= 10;
    }
    for (int j = 0; j < longnumber; j++)
    {
        res = res + array[j];
    }
    System.Console.WriteLine($"Сумма цифр в числе {num} равна {res}");
}

int num = InputInt("Введите число");
int numberlong = Counter(num);
Summator(num, numberlong);