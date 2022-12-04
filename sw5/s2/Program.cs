// See https://aka.ms/new-console-template for more information

// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int [] InverseArrayItems (int [] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
    numbers [i] *= -1;
    }
    return numbers;
}

int [] numbers = GenArray(10, -10, 10);
PrintArray(numbers);
PrintArray(InverseArrayItems(numbers));