// See https://aka.ms/new-console-template for more information
//  Проверка на простое число

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

bool RecursiveSimpleN (int n, int divider)
{
    if (divider == 1)
    {
        return true;
    }
    if (n%divider != 0)
    {
       return RecursiveSimpleN (n, divider - 1);
    }
    else return false;
}

int n = Prompt ("Введите число для проверки");
int m = n - 1;


if (RecursiveSimpleN (n, m) == true)
{
    Console.WriteLine($"Число {n} простое");
}
else Console.WriteLine($"Число {n} не является простым");