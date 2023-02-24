// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

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

void Result(int a, int b)
{
    int res = 1;
    for (int i = 0; i < b; i++)
    {
        res = res*a;
    }
    System.Console.WriteLine($"Число {a} в степени {b} равно {res}");
}

int number = InputInt("Введите число возводимое в степень");
int degree = InputInt("Введите степень в которую возводим число");
Result(number,degree);