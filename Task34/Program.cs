// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
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
int GetEvenNum(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] %2 == 0) result++;
    }
    return result;

}
int[] array = GetArray(10, 100, 999);
Console.Write(string.Join(", ", array));
int result = GetEvenNum(array);
Console.Write($"количество четных чисел равно {result}");