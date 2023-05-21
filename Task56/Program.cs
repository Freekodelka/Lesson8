/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] matrix = new int[4, 4];
int[] results = new int [matrix.GetLength(0)];

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],8}  ");
        }
        Console.WriteLine();
    }
}

void Sum(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumary = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {            
            sumary = sumary + matrix[i, j]; 
        }
        results[i] = sumary;              
    }
}

void FindMin(int[] results)
{
    int min = results[0];
    int minIndex = 0;
    for (int i = 0; i < results.Length; i++)
    {        
        if (results[i] < min)
        {
            min = results[i];
            minIndex = i;
        }
    } 
    Console.WriteLine("Минимальная сумма: " + min + 
    " " + "строки: " + ++minIndex);
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

FillArray();
PrintArray(matrix);
Sum(matrix);
FindMin(results);
