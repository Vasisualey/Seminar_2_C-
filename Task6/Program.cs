// 

Console.Clear();
int count = 1;
while(count<= 100)
{
    if((count%3 == 0) & (count%5 == 0))
    {
        Console.WriteLine("FizzBuzz");
    }
    else if(count%3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if(count%5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(count);
    }
    count++;
}