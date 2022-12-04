// See https://aka.ms/new-console-template for more information

// Задайте одномерный массив из 10 случайных чисел в диапазоне от 1 до 200. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

int [] GenArray (int length, int minRange, int maxRange)
{
    int [] array = new int [length];
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(minRange, maxRange+1);
        }
    return array;
}

int PartChecker (int [] array, int minValue, int maxValue)
{
    int counter = 0;
    foreach (var item in array)
    {
        if (item >= minValue && item <= maxValue)
        {
            counter ++;
        };
    }
    return counter;
}

int Range = Prompt("Введите длину массива ");
int minValue = Prompt("Введите минимальное значение массива");
int maxValue = Prompt("Введите максимальное значение массива");

int startLine = Prompt("Введите начало отрезка проверки");
int endLine = Prompt("Введите конец отрезка проверки");

int [] arr123 = GenArray (Range, minValue, maxValue);
PrintArray (arr123);
int count = PartChecker (arr123, startLine, endLine);
Console.WriteLine($"Количество элементов массива от {startLine} до {endLine} = {count}");
