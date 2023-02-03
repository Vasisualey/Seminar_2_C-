// Напишите программу, которая принимает на вход число,
// и проверяет, кратно ли оно одновременно 7 и 23

Console.Clear();
Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine());

if(number1%7 == 0)
{
    if(number1%23 == 0)
    {
        Console.WriteLine($"{number1} является кратным 7 и 23 одновременно");
    }
    else
    {
        Console.WriteLine($"{number1} не является кратным 7 и 23 одновременно");
    }
}
else
{
    Console.WriteLine($"{number1} не является кратным 7 и 23 одновременно");
}