// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ['hello", "2", "world", ":-)"] -> ["2", "-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []*/

Console.Write("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
string[] array = new string[arrayLength];
for (int i = 0; i < arrayLength; i++)
{
  Console.Write($"Введите значение {i} элемента: ");
  string element = Console.ReadLine()!;
  array[i] = element;
}
int lengthLines = 3;
int sizeModifiedArray = SizeModifiedArray(array, lengthLines);
string[] ArrayTwo = ModifiedArray(array, lengthLines, sizeModifiedArray);
PrintArray(array);
Console.Write(" -> ");
PrintArray(ArrayTwo);
void PrintArray(string[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    else Console.Write($"{array[i]}");
  }
  Console.Write("]");
}
int SizeModifiedArray(string[] array, int lengthLines)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= lengthLines)
      count++;
  }
  return count;
}
string[] ModifiedArray(string[] array, int lengthLines, int sizeNewArray)
{
  string[] newArray = new string[sizeNewArray];
  int i = 0;
  int j = 0;
  while (j < array.Length)
    if (array[j].Length <= lengthLines)
    {
      newArray[i] = array[j];
      i++;
      j++;
    }
    else
    {
      j++;
    }
  return newArray;
}
