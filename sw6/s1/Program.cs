// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



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

void Swap1 (int [] array, int i1, int i2)
{
    int temp = array [i1];
    array[i1] = array [i2];
    array [i2] = temp;
}

void Swap2 (int[] array, int i1, int i2)
{
    (array[i1], array[i2]) = (array[i2], array[i1]);
}


int ArrayReverse (int [] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        Swap1(array, i, array.Length - 1 - i);
    }
    return array;
}

int Range = Prompt("Введите длину массива ");
int minValue = Prompt("Введите минимальное значение массива");
int maxValue = Prompt("Введите максимальное значение массива");

int [] arr = GenArray(Range, minValue, maxValue);
PrintArray (arr);
Console.WriteLine($" - ");