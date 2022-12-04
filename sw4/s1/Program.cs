// See https://aka.ms/new-console-template for more information
 // принимает число и выдает сумму чисел от 1 до него


int Prompt(string message)
{
    System.Console.Write($"{message}>");               
    int answer = Convert.ToInt32(Console.ReadLine()); 
    return answer;
}

int SumNumbers(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

int SumGaussNumbers(int number)
{
    return (1+number)* number/2;
}

int number = Prompt("Введите число");
int result = SumNumbers (number);
int result2 = SumGaussNumbers (number);
Console.WriteLine(result);

