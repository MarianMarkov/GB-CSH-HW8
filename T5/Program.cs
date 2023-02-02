// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Write("Размер квадратного массива: ");
int n = int.Parse(Console.ReadLine()!);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

void SpyrMass(int n)
{
    int[,] sqareMatrix = new int[n, n];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= n * n)
    {
    sqareMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < n - 1)
        j++;
    else if (i < j && i + j >= n - 1)
        i++;
    else if (i >= j && i + j > n - 1)
        j--;
    else
        i--;
    }
    WriteArray(sqareMatrix);
    Console.WriteLine();
}


void ReverseSpyrMass(int n)
{
    int[,] sqareMatrix = new int[n, n];
    int temp = 1;
    int i = 0;
    int j = n-1;
    while (temp <= n * n)
    {
    sqareMatrix[i, j] = temp;
    temp++;
    if (i < j && i + j <= n )
        j--;
    else if (i >= j && i + j < n - 1)
        i++;
    else if (i > j && i + j >= n - 1)
        j++;
    else
        i--;
    }
    WriteArray(sqareMatrix);
}
Console.WriteLine("Спиральный массив");
SpyrMass(n);
Console.WriteLine("Спиральный массив с другой стороны");
ReverseSpyrMass(n);
