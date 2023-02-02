// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void CreateArray(int[,] array)
{   
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
}

void MinSummRow(int[,] array)
{   int MinV = 10*5;
    int MinI = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int CurV = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            CurV = CurV + array[i,j];
        }
        if (CurV < MinV)
        {
            MinV = CurV;
            MinI = i;
        }
    }
    Console.WriteLine($"Минимальная сумма {MinV} в строке {MinI}");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {   Console.Write($"{i}. ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[5, 5];
CreateArray(array);
Console.WriteLine("Изначальный массив");
PrintArray(array);
MinSummRow(array);

