/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
Console.Clear();

Console.WriteLine("Введите количество строк матрицы A (здесь и далее при вводе счет  строк и столбцов ведется с 1, по правилам линейной алгебры)");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матрицы A и число строк матрицы B");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матрицы B");
int k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Минимальное возможное значение в обеих матрицах");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимально возможное значение в обеих матрицах");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Матрица A:");
int[,] A = FillArray(m, n, min, max);
PrintArray(A);

Console.WriteLine("Матрица B:");
int[,] B = FillArray(n, k, min, max);
PrintArray(B);

Console.WriteLine("Матрица C = A * B:");
int[,] C = ComputeProductOfMatrix(A, B);
PrintArray(C);

int[,] FillArray(int arrayRows, int arrayColumns, int minValue, int maxValue)
{
    int[,] filledArray = new int[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            filledArray[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return filledArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] ComputeProductOfMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    int scalarProduct = 0;
    for (int m = 0; m < matrixA.GetLength(0); m++)
    {
        for (int k = 0; k < matrixB.GetLength(1); k++)
        {
            for (int n = 0; n < matrixA.GetLength(1); n++)
            {
                scalarProduct = scalarProduct + matrixA[m, n] * matrixB[n, k];
                matrixC[m, k] = scalarProduct;
            }
            scalarProduct = 0;
        }
    }
    return matrixC;
}

