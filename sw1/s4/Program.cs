// See https://aka.ms/new-console-template for more information

// Напишите программу вычисления функции:
//  x = f(a) функиця куба

Console.Write("Введите число : ");          //вывод приглашения ввода
string inputValue = Console.ReadLine();     //вывод строки с терминала/консоли
int value = Convert.ToInt32(inputValue);    //преобразование строки в число

int cubeValue = value * value * value;            //вычисление квадрата
System.Console.WriteLine("Куб значения " + value + " равен " + cubeValue);
System.Console.WriteLine($"Куб значения {value} равен {cubeValue}");

