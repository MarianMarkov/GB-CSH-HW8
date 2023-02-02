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


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MatProd(int[,] Mat1, int[,] Mat2)
{
    int[,] MatP = new int[Mat1.GetLength(0),Mat2.GetLength(1)];
    for (int i = 0; i < MatP.GetLength(0); i++)
    { 
        for (int j = 0; j < MatP.GetLength(1); j++)
        {
            MatP[i,j] = 0;
            for (int k = 0; k < Mat1.GetLength(1); k++)
            {
                MatP[i,j] = MatP[i,j] + Mat1[i,k] * Mat2[k,j];
            }
        }
        
    }
    Console.WriteLine();
    Console.WriteLine("Результат произведения матриц");
    PrintArray(MatP);
}

int[,] Mat1 = new int[2, 2];
int[,] Mat2 = new int[2, 2];
CreateArray(Mat1);
CreateArray(Mat2);
Console.WriteLine("Матрица 1");
PrintArray(Mat1);
Console.WriteLine();
Console.WriteLine("Матрица 2");
PrintArray(Mat2);
if (Mat1.GetLength(1) != Mat2.GetLength(0))
{
    Console.WriteLine("Неправильный размер исходных матриц");
}
else
{
    MatProd(Mat1, Mat2);
}



