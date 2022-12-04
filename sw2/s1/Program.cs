// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// форматрирование текста - Shift+Alt+F

// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

bool ValidateNumber (int number)
{
    if (number >= 100 && number < 1000);
    {
        return true;
    }
{
    System.Console.WriteLine($"Число не трёхзначное");
    return false;
}
}

int number = Prompt("Введите число");
if (ValidateNumber(number))
{
    int result = number % 10;
    System.Console.WriteLine($"Последняя цифра введенного числа {result}");
}



// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Решение - сравнить

// int Prompt(string message)
// {
//     System.Console.Write($"{message} >");
//     int answer = Convert.ToInt32(Console.ReadLine());
//     return answer;
// }

// bool ValidateNumber(int number)
// {
//     if (number >= 100 && number < 1000)
//     {
//         return true;
//     }

//     System.Console.WriteLine("Число не трехзначное");
//     return false;
// }

// int number = Prompt("Введите число");
// if (ValidateNumber(number))
// {
//     int result = number % 10;
//     System.Console.WriteLine($"Последняя цифра введенного числа {result}");
// }
