﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}
int SUmOddArray(int[] array)
{
    int result = 0;
    for(int i = 1; i < array.Length; i+=2)
    {
        result +=array[i];
    }
    return result;
}

int[] array = GetArray(5, 10, 99);
Console.Write(String.Join(", ", array));
int result = SUmOddArray(array);
Console.Write($" Сумма нечетных элементов равна {result}");