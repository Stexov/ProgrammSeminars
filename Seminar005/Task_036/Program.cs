// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}
Console.WriteLine("Задайте размер масива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте нижнюю границу масива");
int leftRange = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте верхнюю границу масива");
int rightRange = Convert.ToInt32(Console.ReadLine());
int[] massive = GetRandomArray(size, leftRange, rightRange);
Console.WriteLine(string.Join(", ", massive));

int sumN = 0;
for(int i = 1; i < massive.Length; i = i + 2)
{
    sumN += massive[i];
}
Console.WriteLine($"Сумма элементов стоящих на нечётных позициях = {sumN}");