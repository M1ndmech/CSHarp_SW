// See https://aka.ms/new-console-template for more information
// Напишите программу, которая прнимает на вход координаты точки (X и Y), причем x=/=0 или y =/= 0 и выдает номер четверти плоскости

// функция приглашения и ввода целого числа

int Prompt(string message)
{
    System.Console.Write($"{message}>");                // вывод приглашения
    int answer = Convert.ToInt32(Console.ReadLine());   // ввод числа
    return answer;
}

// Проверка на корректность данных, X и Y должны быть больше нуля
bool valQuart(int x, int y)
{
    if (x == 0 || y == 0)   //сама проверка
    {
        System.Console.WriteLine("Одна из координат равна 0");
        return false;
    }

    return true;
}

// получение четверти по координатам
int getQuart(int x, int y)
{
    if (y > 0 && x > 0)
    {
        return 1;       //1 четверть
    }
    if (y > 0 && x < 0)
    {
        return 2;       //2 четверть
    }
    if (y < 0 && x < 0)
    {
        return 3;       //3 четверть
    }
    if (y < 0 && x > 0)
    {
        return 4;       //4 четверть
    }
    return 0;
}

int coordX = Prompt("Введите X");
int coordY = Prompt("Введите Y");

if (valQuart(coordX, coordY))
{
    int quarter = getQuart(coordX, coordY);
    System.Console.WriteLine($"Полученная четверть {quarter}");

}