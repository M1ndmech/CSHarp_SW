// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Составить программу, которая выводит числа от 1 до 100, 
// если число кратно 3, то вместо числа пишет FIZZ, если число кратно 5, 
// то пишем BUZZ, если число кратно и 3 и 5, то пишем FIZZBUZZ

int start = 1;
int end = 100;

// while (start < end)
// {
//     if (start % 15 == 0)
//     {
//         Console.WriteLine("FIZZBUZZ");
//     }

//     else if (start % 5 == 0)
//     {
//         Console.WriteLine("BUZZ");
//     }

//     else if (start % 3 == 0)
//     {
//     Console.WriteLine("FIZZ");
//     }

//     else 
//     Console.WriteLine(start);
//     start +=1;
// }

bool Is_FIZZ (int start)
{
    if (start%3==0)
    {
        Console.WriteLine("FIZZ");
        return true;
    }
    return false;

}
bool Is_BUZZ (int start)
{
    if (start%5==0)
    {
        Console.WriteLine("BUZZ");
        return true;
    }
    return false;

}
while (start <= end)
{
    if (Is_FIZZ(start) | Is_BUZZ(start))
    {
        Console.WriteLine();
    }
    else Console.WriteLine(start);

    start +=1;
}


// Составить программу, которая выводит числа от 1 до 100, 
// если число кратно 3, то вместо числа пишет FIZZ, 
// если число кратно 5, то пишем BUZZ, если число кратно и 3 и 5, 
// то пишем FIZZBUZZ


// альтернативный код
// bool Is_FIZZ (int N)
// {
//     if (N%3==0) 
//     {
//         Console.Write("FIZZ");
//         return true;        
//     }
//     return false;
// }

// bool Is_BUZZ (int N)
// {
//     if (N%5==0) 
//     {
//         Console.Write("BUZZ");
//         return true;        
//     }
//     return false;
// }

// int N = 1;

// while (N <= 100)
// {
//     if (Is_FIZZ(N) | Is_BUZZ(N))
//     {
//         Console.WriteLine();  
//     }
//     else Console.WriteLine(N); 

//     N = N+1;
// }
