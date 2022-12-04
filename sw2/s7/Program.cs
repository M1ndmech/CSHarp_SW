// See https://aka.ms/new-console-template for more information
// int [values] = new int []
// int input1 = Prompt ("Введите число");
// int input2 = Prompt ("Введите число");
// int input3 = Prompt ("Введите число");
// int input4 = Prompt ("Введите число");
// int input5 = Prompt ("Введите число");

// double avg = (input1 + input2 + input3 + input4 + input5)/5.0;
// int sum = (input1 + input2 + input3 + input4 + input5);

// Напишите программу, которая будет принимать на вход пять чисел и выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int len = Prompt ("Введите количество чисел:");

int index = 0;
double sum = 0;

while (index < len)
{
    int value = Prompt ($"Введите {index} число");
    sum = sum + value;
    index++;
}

double avg = sum/index;

Console.WriteLine($"Сумма = {sum}");
Console.WriteLine($"Среднее = {avg:f2}");
