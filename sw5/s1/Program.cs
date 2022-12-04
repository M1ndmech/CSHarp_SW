// See https://aka.ms/new-console-template for more information

// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
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

int Range = Prompt("Введите длину массива ");
int minValue = Prompt("Введите минимальное значение ");
int maxValue = Prompt("Введите максимальное значение ");

int [] array12 = GenArray(Range, minValue, maxValue);
PrintArray (array12);

int SumForSign (int [] array, bool isPositive = true)
{
    int sign = 1;
    if (!isPositive)
    {
        sign = -1;
    }

    int sum = 0;
    foreach (int item in array)
    {
        if (item * sign > 0)
        {
            sum += item;
        }
    }
    return sum;
}

int sumPos = SumForSign(array12);
int sumNeg = SumForSign(array12, false);

Console.WriteLine($"Сумма положительных элементов массива {sumPos}");
Console.WriteLine($"Сумма положительных элементов массива {sumNeg}");