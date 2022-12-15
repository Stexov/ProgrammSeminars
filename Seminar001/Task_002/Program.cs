Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.Write("Максимум = ");
    Console.WriteLine(number1);
    Console.Write("Минимум = ");
    Console.WriteLine(number2);
}
if (number1 < number2)
{
    Console.Write("Максимум = ");
    Console.WriteLine(number2);
    Console.Write("Минимум = ");
    Console.WriteLine(number1);
}
if (number1 == number2)
{
        Console.WriteLine("Числа равны");
}