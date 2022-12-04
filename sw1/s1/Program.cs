// See https://aka.ms/new-console-template for more information
// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.Write("Введите число : ");          //вывод приглашения ввода
string inputValue = Console.ReadLine();     //вывод строки с терминала/консоли
int value = Convert.ToInt32(inputValue);    //преобразование строки в число

int squareValue = value * value;            //вычисление квадрата
System.Console.WriteLine("Квадрат значения " + value + " равен " + squareValue);
System.Console.WriteLine($"Квадрат значения {value} равен {squareValue}");
