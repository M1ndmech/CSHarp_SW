// See https://aka.ms/new-console-template for more information

// Задайте двумерный массив. Найдите максимальный элемент массива и среднее арифметическое всех элементов массива.

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

int MaxInMatrix (int [,] matrix)
{
    int max = 0;
    foreach (int item in matrix)
    {
        if (max < item)
        {
            max = item;
        }
    }
    return max;
}

double MatrixAverage (int [,] matrix)
{
    double sum = 0;
    foreach (int item in matrix)
    {
        sum+= item;
    }
    return sum/matrix.Length;
}

int rowsInput = Prompt("Введите количество строк массива");
int columnsInput = Prompt("Введите количество столбцов массива");
int min = Prompt("Введите минимальное значение для ячеек массива");
int max = Prompt("Введите максимальное значение для ячеек массива");

int [,] newMatrix = GenerateMatrix(rowsInput, columnsInput, min, max);
PrintMatrix (newMatrix);
Console.WriteLine();
Console.WriteLine($"Максимальное значение в массиве - {MaxInMatrix(newMatrix)}");
Console.WriteLine($"Среднее арифметическое всех элементов - {MatrixAverage(newMatrix)}");