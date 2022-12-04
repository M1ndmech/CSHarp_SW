// See https://aka.ms/new-console-template for more information

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да


int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int input1 = Prompt("Введите число");
int leftover1 = input1 % 7;
int leftover2 = input1 % 23;

if (leftover1 == 0 && leftover2 == 0)
{
    Console.WriteLine($"Число {input1} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число {input1} не кратно 7 и 23");
}