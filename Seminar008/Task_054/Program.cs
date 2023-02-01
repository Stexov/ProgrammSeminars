// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] GetMatrixRevers(int[,] array, int rows)
{
    int min = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int k = array.GetLength(1) - 1; k > 0; k--)
        {
            for(int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if(array[i, j] < array[i, j + 1])
                {
                    min = array[i, j];
                    array[i, j] = array[i, j+1];
                    array[i, j + 1] = min;
                }
            }
        }
    
    } 
    return(array);
}

const int rows = 5;
const int columns = 8;
const int leftRange = 10;
const int rightRange = 100;

Console.WriteLine("Исходный массив");
int[, ] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
PrdoubleMatrix(array);
Console.WriteLine();
Console.WriteLine("Искомый массив");
int[, ] arrayRevers = GetMatrixRevers(array, rows);
PrdoubleMatrix(arrayRevers);