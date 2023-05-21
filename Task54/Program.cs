/* Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] matrix = new int[4, 4];

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void SortArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < (matrix.GetLength(1) - 1); k++)
            {
                if (matrix[i, (k + 1)] > matrix[i, k])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, (k + 1)];
                    matrix[i, (k + 1)] = temp;
                }
            }
        }
    }
}

void FillArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
        }
    }
}
Console.WriteLine("Начальный массив: ");
FillArray();
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Отсортированный массив: ");
SortArray();
PrintArray(matrix);