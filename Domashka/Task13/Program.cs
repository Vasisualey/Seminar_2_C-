// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
if(number1 > 99 || number1 < -99)
{
    int number2 = number1;
    while(number2/1000>0)
    {
        number2 = number2 / 10;
    }
    int a1 = number2%10;
    Console.WriteLine($"{number1} -> {a1}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}


