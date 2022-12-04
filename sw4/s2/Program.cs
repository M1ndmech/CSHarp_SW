// See https://aka.ms/new-console-template for more information
 
int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int Counter (int number)
{
    int count = 0;
    while (number > 0)
        {
            count++;
            number /= 10;
        }
    return count;
}

int inputN = Prompt("Введите число");
Console.WriteLine($"Количество цифр в числе {inputN} - {Counter(inputN)}");