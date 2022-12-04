// // See https://aka.ms/new-console-template for more information
// Задача 2: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool NumChecker (int [] array, int number)
{
    foreach (var item in array)
    {
        if (item == number) return true;
    }
    return false;
}


int Range = Prompt("Введите длину массива ");
int minValue = Prompt("Введите минимальное значение ");
int maxValue = Prompt("Введите максимальное значение ");

int checkNum = Prompt("Введите искомое число ");


int [] arr1 = GenArray (Range, minValue, maxValue);
PrintArray (arr1);
if (NumChecker (arr1, checkNum) == true)
{
Console.WriteLine($"Число {checkNum} есть в массиве");
}
else
{
Console.WriteLine($"Числа {checkNum} нет в массиве");
}
