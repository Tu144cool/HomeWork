﻿//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
int count = 2;
while (count <= num)
{
    Console.Write(count +" ");
    count = count + 2;
}
}
else
{
    Console.WriteLine("Ошибка: число меньше единицы");
}