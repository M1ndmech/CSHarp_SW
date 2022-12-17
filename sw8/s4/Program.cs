// See https://aka.ms/new-console-template for more information
// Задача 4: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

void PrintMatrix (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
            Console.WriteLine();
    }
}

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int [,] GenerateMatrix (int rows, int columns, int minRange, int maxRange)
{
    int [,] array = new int [rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = new Random().Next(minRange, maxRange+1);
            }
        }
    return array;
}

(int, int) MatrixMinimumLocation (int [,] array)
{
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                if (array[minI,minJ] > array[i,j])
                {
                    minI = i;
                    minJ = j;
                }
            }
        }
    return (minI, minJ);
}


int [,] OmitMinElementRows(int [,] array, int minI, int minJ)
{
    int [,] newMatrix = new int [array.GetLength(0) - 1, array.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        column = 0;
        if (i == minI) continue;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == minJ) continue;
            newMatrix[row, column] = array [i,j];
            column++;
        }
        row ++;
    }
    return newMatrix;
}


int rowsInput = Prompt("Введите количество строк массива");
int columnsInput = Prompt("Введите количество столбцов массива");
int min = Prompt("Введите минимальное значение для ячеек массива");
int max = Prompt("Введите максимальное значение для ячеек массива");

int [,] newMatrix = GenerateMatrix(rowsInput, columnsInput, min, max);
(int a, int b) = MatrixMinimumLocation(newMatrix);
int [,] omitElement = OmitMinElementRows(newMatrix, a, b);

PrintMatrix (newMatrix);
Console.WriteLine();
Console.WriteLine($"{a}, {b}");
Console.WriteLine();
PrintMatrix(omitElement);