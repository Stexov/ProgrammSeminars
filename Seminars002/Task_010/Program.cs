// Программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Ввдетите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());
if (numbers < 1000)
{
    numbers = numbers % 100;
    numbers = numbers / 10;
    if (numbers < 0)
    {
        numbers = numbers * -1;
    }
    Console.WriteLine($"Вторая цифра числа: {numbers}");
}
else
{
    Console.WriteLine("Введенное число не является трехзначным"); 
}