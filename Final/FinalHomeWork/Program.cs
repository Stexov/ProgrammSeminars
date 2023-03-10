// Написать программу, которая из имеющегося массива строк, длинна которых меньше либо равна 3
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

int ArraySize(string[] array)
{
    int size = 0;
    for(int i = 0; i < array.Length; i++)
    {
        int s = array[i].Length;
        if(s <= 3)
        {
            size++;
        }
    }
    return size;
}
string[] ArraySourse(string[] array, string[] arrayFinal)
{
    int j = 0;
    for(int i = 0; i < array.Length; i++)
    {
        int s = array[i].Length;
        if(s <= 3)
        {
            arrayFinal[j] = array[i];
            j++;
        }
    }
    return arrayFinal;
}

Console.WriteLine("Ввдедите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
string[] arrayInit = new string[n];
for(int i = 0; i < n; i++)
{
    Console.WriteLine($"Ввдедите элемент массива - {i + 1}");
    arrayInit[i] = new string(Console.ReadLine());
}

Console.WriteLine("Исходный массив");
PrintArray(arrayInit);
int m = ArraySize(arrayInit);
Console.Write($"Количество удолетворящих элементов = {m}");
Console.WriteLine();
string[] arrayFinal = new string[m];
ArraySourse(arrayInit, arrayFinal);
Console.WriteLine("Искомый массив");
PrintArray(arrayFinal);