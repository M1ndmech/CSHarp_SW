// See https://aka.ms/new-console-template for more information
// Определите, является ли число степенью двойки:


int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

bool RecursivePowerOfTwo (int n)
{
    if (n %2 != 0)
    {
        return false;
    }
    if (n == 2)
    {
        return true;
    }
    return RecursivePowerOfTwo (n/2);
}

int n = Prompt ("Введите число для проверки");

if (RecursivePowerOfTwo (n) == true)
{
    Console.WriteLine($"Число {n} является степенью двойки");
}
else Console.WriteLine($"Число {n} не является степенью двойки");