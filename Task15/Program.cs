// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Clear();
Console.Write(" Введите номер дня недели ");
int num = int.Parse(Console.ReadLine()!);
if(num >=1 && num <= 5)
{
    Console.WriteLine("Это будний день ");
}
else
{
    Console.WriteLine("Это выходной день ");
}
