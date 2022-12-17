/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимально возможное значение в двумерном массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимально возможное значение в двумерном массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns, min, max);
PrintArray(array);

Console.WriteLine($"Номер строки с наименьшей суммой элементов: {GetMinValueOfTheArray(ComputeSumOfStringsElementsOfArray(array))}");

int[,] FillArray(int ArrayRows, int ArrayColumns, int minValue, int maxValue)
{
    int[,] filledArray = new int[ArrayRows, ArrayColumns];
    Random random = new Random();
    for (int i = 0; i < ArrayRows; i++)
    {
        for (int j = 0; j < ArrayColumns; j++)
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

int[] ComputeSumOfStringsElementsOfArray(int[,] inputArray)
{
    int sumOfStringsElements = 0;
    int[] sumOfStringsElementsOfArray = new int[inputArray.GetLength(0)];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sumOfStringsElements = sumOfStringsElements + inputArray[i, j];
        }
        sumOfStringsElementsOfArray[i] = sumOfStringsElements;
        sumOfStringsElements = 0;
    }
    return sumOfStringsElementsOfArray;
}

int GetMinValueOfTheArray(int[] inputArray)
{
    int iMin=0;
    int minValue = 0;
    minValue = inputArray[0];
    for (int i = 1; i < inputArray.Length; i++)
    {
        if (inputArray[i] < minValue) { minValue = inputArray[i]; iMin = i;}
    }
    return iMin;
}