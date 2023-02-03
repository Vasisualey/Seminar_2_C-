// Напишите программу, которая выводит случайное трехзначное 
// число и удаляет вторую цифру этого числа

Console.Clear();
int number1 = new Random().Next(100,1000);
int a1 = number1 / 100;
int a2 = number1 % 10;
Console.WriteLine($"{number1} -> {a1}{a2}");
