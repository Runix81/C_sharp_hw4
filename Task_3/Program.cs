//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

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

int[] Array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArr(int[] arr)
{
    int count = arr.Length;
    System.Console.Write("[");
    for (int i = 0; i < count - 1; i++)
    {
        System.Console.Write($"{arr[i]}, ");
    }
    System.Console.WriteLine($"{arr[count - 1]}]");

}

int size = InputInt("Введите размер массива");
int[] array = Array(size);
PrintArr(array);