// See https://aka.ms/new-console-template for more information

int Prompt(string message)
{
    System.Console.Write($"{message}>");                // вывод приглашения
    int answer = Convert.ToInt32(Console.ReadLine());   // ввод числа
    return answer;
}

int quartNum = Prompt("Введите четверть");

switch (quartNum)
{
    case 1:
        System.Console.WriteLine("y > 0, x > 0");
        break;
    case 2:
        System.Console.WriteLine("y > 0, x < 0");
        break;
    case 3:
        System.Console.WriteLine("y < 0, x < 0");
        break;
    case 4:
        System.Console.WriteLine("y < 0, x > 0");
        break;
    default: 
        System.Console.WriteLine("Ошибка! Некорректный номер четверти");
        break;
}
