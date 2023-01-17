// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

Console.WriteLine("Введите размер массива:");
int size = 0;
size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
Console.WriteLine("Введите элементы массива:");
for(int i = 0; i < arr.Length; i++)
{
    Console.Write($"Элемент{i+1} ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

for(int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
Console.WriteLine(string.Join(", ", arr));