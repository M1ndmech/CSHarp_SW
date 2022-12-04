// See https://aka.ms/new-console-template for more information

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int input1 = Prompt("Введите первое число");
int input2 = Prompt("Введите второе число");
int leftover = input2 % input1;

if (leftover == 0)
{
    Console.WriteLine($"Число {input2} кратно числу {input1} ");
}
else
{
    Console.WriteLine($"Остаток от деления {input2} на {input1} равен {leftover}");
}