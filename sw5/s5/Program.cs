// See https://aka.ms/new-console-template for more information

// Задача 4: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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

int [] multArr (int [] array)
{
    int [] newArr  = new int[array.Length/2 + array.Length%2];
    newArr [newArr.Length-1] = array [newArr.Length-1];
    for (int i = 0; i < array.Length/2; i++)
    {
        newArr[i] = array [i] * array [array.Length - 1 - i];
    }
    return newArr;
}

int Range = Prompt("Введите длину массива ");
int minValue = Prompt("Введите минимальное значение массива");
int maxValue = Prompt("Введите максимальное значение массива");

int [] arr = GenArray(Range, minValue, maxValue);
int [] arrMult = multArr(arr);
PrintArray (arr);
PrintArray (arrMult);