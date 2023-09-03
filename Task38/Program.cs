// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}


void FillArray(double[] arrayToFill)
{
    Random rnd = new Random();
    for (int i = 0; i < arrayToFill.Length; i++)
        arrayToFill[i] = rnd.NextDouble();
}

void PrintArray(double[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length - 1; i++)
    {
        Console.Write($"{arrayToPrint[i]}, ");
    }
    Console.Write($"{arrayToPrint[arrayToPrint.Length - 1]}");
    Console.WriteLine("]");
}

double DiffMaxMin(double[] arr)
{
    double maxValue = arr[0];
    double minValue = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxValue) 
        {
            maxValue = arr[i];
        }
        if (arr[i] < minValue) 
        {
            minValue = arr[i];
        }
    }

    return maxValue - minValue;
}

int size = InputNum("Введите размер массива");
double[] array = new double[size];

FillArray(array);
PrintArray(array);

double diff = DiffMaxMin(array);
Console.WriteLine(diff);




