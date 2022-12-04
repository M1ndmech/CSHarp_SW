// See https://aka.ms/new-console-template for more information
// Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). Постарайтесь сделать одним циклом 
// [1, 3, 5, 6, 6, 4] -> 5

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int Prompt(string message)
{
    System.Console.Write($"{message}>");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int [] GenArray (int length, int minRange, int maxRange)
{
    int [] array = new int [length];
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(minRange, maxRange+1);
        }
    return array;
}
// int maxValueIndex(int [] array)
// {
//     int maxValue1 = int.MinValue;
//     int maxValue2 = int.MinValue;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i]=maxValue1)
//         {
//             continue;
//         }
//         if (array[i] > maxValue1);
//         maxValue1 = array [i];
//     }
// }


// int Range = Prompt("Введите длину массива ");
// int minValue = Prompt("Введите минимальное значение ");
// int maxValue = Prompt("Введите максимальное значение ");

// int [] arr = GenArray (Range, minValue, maxValue);
// PrintArray(arr);

// Console.WriteLine($"Максимальный элемент массива равен {maxValue2}");


// int maxValueIndex(int[] array){
//     int maxValue = array[0];
//     for (int i=1; i<array.Length; i++){
//         if (maxValue<array[i]){
//             maxValue = array[i];
//         }
//     }
//     return maxValue;
// }

int maxValueIndex(int[] array){
    int maxValue1 = int.MinValue;
    int maxValue2 = int.MinValue;
    for (int i=1; i<array.Length; i++){
        if (maxValue1<array[i]){
            maxValue1 = array[i];

        }
    }

    for (int i=1; i<array.Length; i++) {
        if (array[i] == maxValue1){
                continue;
        }
        if (maxValue2 < array[i]) {
            maxValue2 = array[i];
        }
    }

    return maxValue2;
}


int Range = Prompt("Введите длину массива ");
int minValue = Prompt("Введите минимальное значение ");
int maxValue = Prompt("Введите максимальное значение ");


int [] arr = GenArray(Range, minValue, maxValue);
PrintArray(arr);
Console.WriteLine("Второй максимум массива равен: " + maxValueIndex(arr));