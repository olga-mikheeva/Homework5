// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}


void FillArray (int[] ints)
{   Random rnd = new Random();
    for (int i = 0; i < ints.Length; i++)
        ints[i] = rnd.Next(100, 1000);     
}

void PrintArray (int[] ints)
{
    Console.Write("[");
    for (int i = 0; i < ints.Length -1; i++)
    {
        System.Console.Write($"{ints[i]}, ");
    }
    Console.Write($"{ints[ints.Length -1]}");
    Console.WriteLine("]");
}

int EvenNumber(int[] ints)
{
    int number = 0;
    for (int i = 0; i < ints.Length; i++)
    {
        if (ints[i] % 2 == 0)
            number++;
    }
    return number;
}


int size = InputNum("Введите размер массива");
int[] ints = new int[size];

FillArray(ints);
PrintArray(ints); 

int sum = EvenNumber(ints);

System.Console.WriteLine(sum);
