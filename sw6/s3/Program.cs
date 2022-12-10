// See https://aka.ms/new-console-template for more information

// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

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

int [] ToBinary (int input)
{
    int [] number = new int [8];
    int count = 1;
    while (input > 0)
    {
        int leftover = input % 2;
        number[number.Length-count] = leftover;
        count++;
        input = input/2;
    }
    return number;
}

int A = Prompt("Введите число");
PrintArray(ToBinary(A));
