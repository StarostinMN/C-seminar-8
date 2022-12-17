/* Демонстрация решения
Задача 60: Найти разницу между максимальным и минимальным значением элемента в двумерном массиве заполненном случайными числами
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
Разница между максимальным и минимальным элементом в массиве = 79 */
//Задача 60: Найти разницу между максимальным и минимальным значением элемента
// в двумерном массиве заполненном случайными числами

// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1  

// Разница между максимальным и минимальным элементом в массиве = 79

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

Console.WriteLine($"Разница между максимальным и минимальным элементом в массиве = {GetMaxValue(array) - GetMinValue(array) }");

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

int GetMinValue(int[,] inputArray){
    
    int min = inputArray[0,0];

    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if(inputArray[i,j] < min)
                min = inputArray[i,j];
        }
    }
    return min;
}

int GetMaxValue(int[,] inputArray){
    
    int max = inputArray[0,0];

    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if(inputArray[i,j] > max)
                max = inputArray[i,j];
        }
    }
    return max;
}