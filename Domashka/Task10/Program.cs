// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
if(number1>99 && number1<1000)
{
    int a1 = number1 / 10;
    int a2 = a1%10;
    Console.WriteLine($"{number1} -> {a2}");
}
else
{
Console.WriteLine("Число не является трехзначным");
}
