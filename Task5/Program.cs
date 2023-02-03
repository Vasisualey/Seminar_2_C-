// Напишите программу, которая принимает на входм\ два числа и проверяет
// является ли одно число квадратом другого

Console.Clear();
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if(number1*number1 == number2)
{
   Console.WriteLine($"{number2} является квадратом {number1}");
}
if(number2*number2 == number1)
{
    Console.WriteLine($"{number1} является квадратом {number2}");
}
else
{
    Console.WriteLine("Ни одно из введённых чисел не является квадратом другому");
}