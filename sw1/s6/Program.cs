// See https://aka.ms/new-console-template for more information
// Напишите программу вычисления модуля числа.
// 	2 -> 2
// 	-3 -> 3
// 	-7 -> 7

Console.Write("Введите число : ");          //вывод приглашения ввода
string inputValue = Console.ReadLine();     //вывод строки с терминала/консоли
int value = Convert.ToInt32(inputValue);    //преобразование строки в число

if (value < 0)
{
    value = -value;
    System.Console.WriteLine(value);
}
else
    System.Console.WriteLine(value);