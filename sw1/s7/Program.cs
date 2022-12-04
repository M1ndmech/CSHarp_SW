// See https://aka.ms/new-console-template for more information
// Напишите программу, которая на вход принимает значение, а  на выходе показывает обратное значение.
// 1 -> 1 
// 2 -> 0.5
// 0.25 -> 4
Console.Write("Введите число : ");          //вывод приглашения ввода
string inputValue = Console.ReadLine();     //вывод строки с терминала/консоли
double value = Convert.ToDouble(inputValue);    //преобразование строки в число

double valueRev = 1/value;

System.Console.WriteLine(valueRev);
System.Console.WriteLine($"Обратное число {value:f2} это {valueRev:f2}");