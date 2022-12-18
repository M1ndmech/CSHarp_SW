// See https://aka.ms/new-console-template for more information

// Вывод числе от 0 до N с помощью рекурсии

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

void RecursiveNumbers (int number)
{
    if (number == 0)
    {
        return;
    }
    System.Console.WriteLine($"{number}; "); // реверсивная
    RecursiveNumbers (number - 1);
    System.Console.WriteLine($"{number}; "); // обратно возвращает из стека
}

int number = Prompt ("Введите число: ");
RecursiveNumbers (number);