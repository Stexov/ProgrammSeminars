Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = number1 / number2;
if (result == number2)
{
    Console.WriteLine("Первое число есть квадрат второго");
}
else
{
    Console.WriteLine("Первое число не квадрат второго");
}




