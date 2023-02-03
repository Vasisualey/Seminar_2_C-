// Напишите программу, которая будет принимать на вход
// два числа и выводить, является ли второе число
// кратным первому. Если второе число не крастно первому,
// то программа выводит остаток от деления.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

int rem =number2%number1;
if(rem == 0)
{
    Console.WriteLine($"{number2} является кратным {number1}");
}
else
{
    Console.WriteLine($"{number2} не является кратным {number1}. Остаток деления {number2} на {number1} равен {rem}");   
}