// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// cоставить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. Значения элементов массива 0..9

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

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
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

int [] FrequencyDict (int min, int length, int [,] matrix)
{
    int [] dict = new int [length];
    foreach (var item in matrix)
    {
        dict [item] ++; // нужен сдвиг начала dict на 1
    }
    return dict;
}

int rowsInput = Prompt("Введите количество строк массива");
int columnsInput = Prompt("Введите количество столбцов массива");
int min = Prompt("Введите минимальное значение для ячеек массива");
int max = Prompt("Введите максимальное значение для ячеек массива");

int length = max + 1 - min;
int [,] matrix1 = GenerateMatrix(rowsInput, columnsInput, min, max);
int [] dict1 = FrequencyDict(min, length, matrix1);
PrintMatrix(matrix1);
Console.WriteLine();
PrintArray(dict1);