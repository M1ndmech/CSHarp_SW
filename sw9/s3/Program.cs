// See https://aka.ms/new-console-template for more information

// напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int RecursiveDigitSum (int n)
{
    if (n == 0)
    {
        return 0;
    }
    return n%10 + RecursiveDigitSum (n/10);
}
int n = Prompt ("Введите число для расчёта суммы его цифр");

Console.WriteLine(RecursiveDigitSum (n));