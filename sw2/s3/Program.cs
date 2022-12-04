// See https://aka.ms/new-console-template for more information

// 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int input1 = Prompt("Введите первое число");
int input2 = Prompt("Введите второе число");

if (input2 % input1 == 0)
{
    Console.WriteLine($"Число {input2} кратно числу {input1} ");
}
else
{
    Console.WriteLine($"Число {input2} не кратно числу {input1} ");
}