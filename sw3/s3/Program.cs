// // See https://aka.ms/new-console-template for more information

// Задача 3: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

int Prompt(string message)
{
    System.Console.Write($"{message}>");                // вывод приглашения
    int answer = Convert.ToInt32(Console.ReadLine());   // ввод числа
    return answer;
}

int xA = Prompt("Введите X для точки A");
int yA = Prompt("Введите Y для точки A");
int xB = Prompt("Введите X для точки B");
int yB = Prompt("Введите Y для точки B");
int deltaX = xB - xA;
int deltaY = yB - yA;

double distance = Math.Sqrt(deltaX*deltaX + deltaY*deltaY);
Console.WriteLine($"Расстояние от A до B равно {distance:f3}");
