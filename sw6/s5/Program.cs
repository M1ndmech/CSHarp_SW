// See https://aka.ms/new-console-template for more information
// Задача 4: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


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

int [] CopyArray (int [] array)
{
    int [] array2 = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array2[i]=array[i];
    }
    return array2;
}

int [] arr1 = GenArray (8, 1, 10);
int [] arr2 =CopyArray (arr1);

arr1[0]=999;
PrintArray(arr1);
PrintArray(arr2);
