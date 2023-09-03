// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int InputNum (string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(int[] array, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(minValue, maxValue + 1);
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length -1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length -1]}");
    Console.WriteLine("]");
}

int SumOddNumber(int[] array)
{
    int oddSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
            oddSum += array[i];
    }
    return oddSum;
}

int size = InputNum("Введите размер массива");
int min = InputNum("Введите минимальное значение эелемента массива: ");
int max = InputNum("Введите максимальное значение элемента массива: ");
int[] arr = new int[size];

FillArray(arr, min, max);
PrintArray(arr);
int sum = SumOddNumber(arr);
Console.WriteLine(sum);

