// See https://aka.ms/new-console-template for more information
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Write("Введите номер дня недели: ");
string inputValue1 = Console.ReadLine();     
int value1 = Convert.ToInt32(inputValue1);  

switch (value1) 
{
    case 1: System.Console.WriteLine("Понедельник");break;
    case 2: System.Console.WriteLine("Вторник");break;
    case 3: System.Console.WriteLine("Среда");break;
    case 4: System.Console.WriteLine("Четверг");break;
    case 5: System.Console.WriteLine("Пятница");break;
    case 6: System.Console.WriteLine("Суббота");break;
    case 7: System.Console.WriteLine("Воскресенье");break;
    default: System.Console.WriteLine("промах!");break;
}