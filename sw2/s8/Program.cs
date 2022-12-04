// See https://aka.ms/new-console-template for more information

// 4.1. Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.
// Введенное число 2
// 13 -> нет 
// 15 -> нет 
// 12 -> да

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int check = Prompt("Введите проверяемое число");

while (true)
{
    int value = new Random().Next(0,10);
    Console.WriteLine($"{value} > нет");
    if (value % check == 0);
    {
        Console.WriteLine($"{value} > да");
        break;
    }
}

// while (true)
// {
//     int value = new Random().Next(0,10);
//     Console.WriteLine(value);
//     if (value % check == 0)
//     {
//         Console.WriteLine($"Мы нашли делитель, это - {value}");
//         break;
//     }
// }
