// Программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
int sat = Convert.ToInt32(Console.ReadLine());
int num = 0;
if (sat > 99999)
{
    Console.WriteLine("Введенное число не удолетворяет условию");
    return;
}
int[] array = new int[5];
for (int i = 5; i > 0; i--)
{
    num = sat % 10;
    array[i-1] = num;
    sat = sat / 10;
}
if (array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine("Введенное число палиндромом");
}
else
{
    Console.WriteLine("Введенное число не палиндромом");
}