/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
Console.Clear();
Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Минимальное возможное значение в двумерном массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальное возможное значение в двумерном массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns, min, max);

Console.WriteLine("Исходный массив:");
PrintArray(array);
int[,] copiedArray = CopyArray(array);
Console.WriteLine("Массив с отсортированными по убыванию элементами строк:");
PrintArray(SortingRowElementsInDescendingOrder(copiedArray));

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

int[,] CopyArray(int[,] inputArray)
{
    int[,] copiedArray = new int[inputArray.GetLength(0), inputArray.GetLength(1)];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            copiedArray[i, j] = inputArray[i, j];
        }
    }
    return copiedArray;
}

int[,] SortingRowElementsInDescendingOrder(int[,] inputArray)
{
    int[,] sortedArray = new int[inputArray.GetLength(0), inputArray.GetLength(1)];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sortedArray[i, j] = inputArray[i, j];
        }
        for (int m = 0; m < inputArray.GetLength(1) - 1; m++)
        {
            int maxPosition = m;
            for (int n = m + 1; n < inputArray.GetLength(1); n++)
            {
                if (sortedArray[i, n]> sortedArray[i, maxPosition])
                {
                    int temp=sortedArray[i, n];
                    sortedArray[i,n]=sortedArray[i,maxPosition];
                    sortedArray[i,maxPosition]=temp;
                }
            }
        }
    }
    return sortedArray;
}

