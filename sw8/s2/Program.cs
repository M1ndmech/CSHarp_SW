// See https://aka.ms/new-console-template for more information
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int [,] GenerateSquareMatrix (int rowsColumns, int minRange, int maxRange)
{
    int [,] array = new int [rowsColumns, rowsColumns];
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = new Random().Next(minRange, maxRange+1);
            }
        }
    return array;
}

int [,] TransponateMatrix (int [,] matrix)
{
    int [,] matrixT = new int [matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrixT [j,i] = matrix [i,j];
        }
    }
    return matrixT;
}

int rowsColumnsInput = Prompt("Введите количество строк/столбцов массива");
int min = Prompt("Введите минимальное значение для ячеек массива");
int max = Prompt("Введите максимальное значение для ячеек массива");

int [,] newMatrix = GenerateSquareMatrix(rowsColumnsInput, min, max);
int [,] matrixT = TransponateMatrix(newMatrix);

PrintMatrix(newMatrix);
Console.WriteLine();
PrintMatrix(matrixT);