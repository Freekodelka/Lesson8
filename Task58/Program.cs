/*  Задайте две матрицы. Напишите программу, 
 которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
const int Len = 4;
int[,] matrixA = new int[Len, Len];
int[,] matrixB = new int[Len, Len];

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

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

int [,] MultiplicationArray (int[,] matrixA, int[,] matrixB)
{
    int n = matrixA.GetLength(0);
    int [,] matrixC = new int [n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int sum = 0;
            for (int k = 0; k < n; k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }
            matrixC[i, j] = sum;
        }
    }
    return matrixC;    
}

FillArray(matrixA);
Console.WriteLine("Матрица A: ");
PrintArray(matrixA);
FillArray(matrixB);
Console.WriteLine("Матрица B: ");
PrintArray(matrixB);
Console.WriteLine("Произведение матриц ");
PrintArray(MultiplicationArray (matrixA, matrixB));