// Программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Ввдетите цифру обозначающую день недели: ");
int numbers = Convert.ToInt32(Console.ReadLine());
if (numbers > 7)
{
    Console.WriteLine("Введенное число не удолетворяет диапазону");
//    break;
}
if (numbers < 6)
{
    Console.WriteLine("Этот день рабочий");
}
else
{
    Console.WriteLine("Этот день выходной");
}