// See https://aka.ms/new-console-template for more information
// Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

Console.Write("Введите число 1 : ");
string inputValue1 = Console.ReadLine();     
int value1 = Convert.ToInt32(inputValue1);  
int value1sq = value1 * value1;

Console.Write("Введите число 2 : ");
string inputValue2 = Console.ReadLine();     
int value2 = Convert.ToInt32(inputValue2);  

if (value1sq == value2)
{
    Console.WriteLine($"Число {value2} это квадрат числа {value1}");
}
else
{
    
    Console.WriteLine($"Число {value2} это не квадрат числа {value1}");
}