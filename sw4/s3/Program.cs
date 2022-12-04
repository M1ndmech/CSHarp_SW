// See https://aka.ms/new-console-template for more information

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24

 
int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int value = Prompt("Введите число");
int Factorial (int value)
{
     int value2 = 1;
    for (int i=1; i<=value; i++){
        value2 = value2 * i;
    
    }
    return value2;
}

Console.WriteLine($"Произведение чисел от 1 до {value} будет равно {Factorial(value)}");
