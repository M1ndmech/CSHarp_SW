// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

bool TriangleCheck (int a, int b, int c)
{
    if (a + b > c)
    {
        return true;
    }
    return false;
}

int A = Prompt("Введите длину первой стороны");
int B = Prompt("Введите длину второй стороны");
int C = Prompt("Введите длину третьей стороны");

if (TriangleCheck(A,B,C) && TriangleCheck(B,C,A) && TriangleCheck(C,B,A) == true)
{
Console.WriteLine ($"Треугольник со сторонами {A}, {B}, и {C} существует");
}
else Console.WriteLine ($"Треугольник со сторонами {A}, {B}, и {C} не существует");