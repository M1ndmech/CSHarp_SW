// See https://aka.ms/new-console-template for more information
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

int [,] RowsReplace (int [,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int lastRow = matrix.GetLength(0) - 1;
        int temp = matrix[0,j];
        matrix [0,j] = matrix [lastRow, j];
        matrix [lastRow, j] = temp;
    }
    return matrix;
}

int rowsInput = Prompt("Введите количество строк массива");
int columnsInput = Prompt("Введите количество столбцов массива");
int min = Prompt("Введите минимальное значение для ячеек массива");
int max = Prompt("Введите максимальное значение для ячеек массива");

int [,] matrix1 = GenerateMatrix(rowsInput, columnsInput, min, max);

PrintMatrix (matrix1);
Console.WriteLine();
PrintMatrix (RowsReplace(matrix1));