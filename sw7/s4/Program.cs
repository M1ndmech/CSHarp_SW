// See https://aka.ms/new-console-template for more information
// Задача 2: Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, и замените эти элементы на их квадраты.

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

int [,] MultiplyMatrixEvens (int [,] array)
{
     for (int i = 1; i < array.GetLength(0); i+=2)
        {
            for (int j = 1; j < array.GetLength(1); j+=2)
            {
                array[i,j] = array[i,j]*array[i,j];
            }
        }
    return array;
}

int rowsInput = Prompt("Введите количество строк массива");
int columnsInput = Prompt("Введите количество столбцов массива");
int min = Prompt("Введите минимальное значение для ячеек массива");
int max = Prompt("Введите максимальное значение для ячеек массива");

int [,] newMatrix = GenerateMatrix(rowsInput, columnsInput, min, max);
PrintMatrix (newMatrix);
Console.WriteLine();
PrintMatrix(MultiplyMatrixEvens(newMatrix));
