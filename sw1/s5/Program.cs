// See https://aka.ms/new-console-template for more information
// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число : ");          //вывод приглашения ввода
string inputValue = Console.ReadLine();     //вывод строки с терминала/консоли
int value = Convert.ToInt32(inputValue);    //преобразование строки в число

int valueRev = value * (-1);

while (valueRev <= value)
{
    System.Console.WriteLine(valueRev);
    valueRev += 1;
}
