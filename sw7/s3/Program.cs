// See https://aka.ms/new-console-template for more information
// Таблица умножения!

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

int [,] GenerateSumMatrix (int rows, int columns)
{
    int [,] array = new int [rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = (i+1)*(j+1);
            }
        }
    return array;
}

int rowsInput = Prompt("Введите количество строк массива");
int columnsInput = Prompt("Введите количество столбцов массива");

PrintMatrix (GenerateSumMatrix(rowsInput, columnsInput));

