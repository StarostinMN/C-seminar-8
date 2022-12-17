/* Решение в группах задач:
Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 2, 3 
4, 6, 1 
2, 1, 6

1 встречается 3 раза 
2 встречается 2 раз 
3 встречается 1 раз 
4 встречается 1 раз 
6 встречается 2 раза */
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

PrintArray(array);
Console.WriteLine("____________________________________________________________________");
int maxValue = GetMaxValue(array);
GetFrequencyDictionaryOfArrayElements(array, maxValue);

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

int GetMaxValue(int[,] inputArray)
{

    int max = inputArray[0, 0];

    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (inputArray[i, j] > max)
                max = inputArray[i, j];
        }
    }
    return max;
}

void GetFrequencyDictionaryOfArrayElements(int[,] inputArray, int maxValue)
{
    int excludedValue = maxValue + 1;
    int countCurrentNumber = 0;
    int currentNumber = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            currentNumber = inputArray[i, j];
            for (int k = 0; k < inputArray.GetLength(0); k++)
            {
                for (int m = 0; m < inputArray.GetLength(1); m++)
                {
                    if (inputArray[k, m] == currentNumber)
                    {
                        countCurrentNumber++;
                        inputArray[k, m] = excludedValue;
                    }
                }
            }
            if (currentNumber != excludedValue)
            {
                Console.WriteLine($"{currentNumber} встречается {countCurrentNumber} раз(а)");
            }
            countCurrentNumber = 0;
        }
    }
}

