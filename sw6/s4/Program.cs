// See https://aka.ms/new-console-template for more information

// Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


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
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

int [] Fibonacci (int num)
{
    int [] fRow = new int [num];
    fRow [0] = 0;
    fRow [1] = 1;
    for (int i = 2; i < num; i++)
    {
        fRow[i]=fRow[i-1]+fRow[i-2];
    }
    return fRow;

}

PrintArray(Fibonacci(Prompt("Введите число ")));
