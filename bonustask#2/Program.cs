/* Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
Дополнительная задача 2 (задача со звёздочкой):. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Console.Clear();

int M = 5;
int N = 5;

PrintArray(FillArrayInASpiral(M, N));

int[,] FillArrayInASpiral(int m, int n)
{
    int[,] array = new int[m, n];
    int i = 0, j = 0, count = 1;
    array[0, 0] = 1;

    while (count < m * n)
    {
        if (j + 1 < n && array[i, j + 1] == 0)//right
        {
            array[i, j + 1] = array[i, j] + 1;
            j++;
            count++;
        }
        else if (i + 1 < m && array[i + 1, j] == 0)//down
        {
            array[i + 1, j] = array[i, j] + 1;
            i++;
            count++;
        }
        else if (j - 1 >= 0 && array[i, j - 1] == 0)//left
        {
            array[i, j - 1] = array[i, j] + 1;
            j--;
            count++;
        }
        else if (i - 1 >= 0 && array[i - 1, j] == 0) //up
        {
            array[i - 1, j] = array[i, j] + 1;
            i--;
            count++;
            for (int k = 0; k < m - 2; k++)
            {
                if (i - 1 >= 0 && array[i - 1, j] == 0) //up
                {
                    array[i - 1, j] = array[i, j] + 1;
                    i--;
                    count++;
                }
            }
        }
    }
    return array;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (inputArray[i, j] < 10)
            {
                Console.Write("0" + inputArray[i, j] + " ");
            }
            else
            {
                Console.Write(inputArray[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}