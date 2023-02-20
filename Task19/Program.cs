// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
int sum = 0;
for(t=num;num!=0;num=num/10)
{
    r = num % 10;  
    sum = sum * 10 + r;
}
if(t == sum)
{
    Console.Write("Палиндром");
}
else
{
    Console.Write("Не Палиндром");
}