// See https://aka.ms/new-console-template for more information
// массив из 8 элементов в случайном порядке из нулей и единиц


void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
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

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int Range = Prompt("Введите длину массива ");
int minValue = Prompt("Введите минимальное значение ");
int maxValue = Prompt("Введите максимальное значение ");

int [] arr = GenArray (Range, minValue, maxValue);
PrintArray(arr);
