// See https://aka.ms/new-console-template for more information
// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int RecursivePower (int n, int m)
{
    if (m == 0)
    {
        return 1;
    }
    return n * RecursivePower (n, m - 1);
}
int n = Prompt ("Введите число для возведения в степень:");
int m = Prompt ("Введите степень:");


Console.WriteLine($"Число {n} в степени {m} равно {RecursivePower(n, m)}");