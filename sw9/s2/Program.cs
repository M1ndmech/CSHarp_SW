// See https://aka.ms/new-console-template for more information

// Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

void RecursiveMtoN (int m, int n)
{
    if (m == n + 1)
    {
        return;
    }
    Console.WriteLine(($"{m}; "));
    RecursiveMtoN (m + 1, n);
}
int start = Prompt ("Введите число, от которого считаем: ");
int finish = Prompt ("Введите число, до которого считаем: ");
RecursiveMtoN (start, finish);