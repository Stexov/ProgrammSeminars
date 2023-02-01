// Задача 56: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GetRandomMatrix(int rows, int column, int leftRange, int rightRange)
{
    int[, ] matrix = new int[rows, column];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange);
        }
    } 
    return(matrix);
}

void PrdoubleMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    } 
}

int MinStringSearch(int[,] array)
{
    int sumString = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        sumString = sumString + array[0, j];
    }
    Console.WriteLine($"Сумма элементов строки 1 = {sumString}");
    int min = sumString;
    sumString = 0;
    int numStringMin = 1;
    for(int i = 1; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sumString = sumString + array[i, j];
        }
        Console.WriteLine($"Сумма элементов строки {i+1} = {sumString}");
        if(sumString < min)
        {
            min = sumString;
            numStringMin = i + 1;
        }
        sumString = 0;
    } 
    return(numStringMin);
}

const int rows = 8;
const int columns = 8;
const int leftRange = 10;
const int rightRange = 100;

Console.WriteLine("Исходный массив");
int[, ] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
PrdoubleMatrix(array);

int result = MinStringSearch(array);

Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элентов № {result}");