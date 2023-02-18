// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowResult(int[] array)
// {
//     int counter = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//         if(array[i] % 2 == 0) counter++;
//     }
//     Console.WriteLine();
//     Console.Write("-> " + counter);
// }

// Console.Write("Введите размер одномерного массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимально возможное значение элемента массива: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимально возможное значение элемента массива: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// ShowResult(CreateRandomArray(size, minValue, maxValue));

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowResult(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if((i != 0) && (i % 2 != 0)) sum += array[i];
    }
    Console.WriteLine();
    Console.Write("-> " + sum);
}

Console.Write("Введите размер одномерного массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное значение элемента массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное значение элемента массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

ShowResult(CreateRandomArray(size, minValue, maxValue));