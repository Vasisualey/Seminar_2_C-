// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
if(number1>0 && number1<6)
{
    Console.WriteLine("Нет");
}
if(number1>5 && number1<8)
{
    Console.WriteLine("Да");
}
if(number1>7 || number1<1)
{
    Console.WriteLine("Это не день недели");
}