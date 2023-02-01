//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GetRandomMatrix(int rows, int column, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, column];

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

int[,] MultiplicationMatrix(int[,] matrix_1, int[,] matrix_2, int rows, int column)
 {
    int[,] matrix = new int[rows, column];
    for(int k = 0; k < matrix.GetLength(0); k++)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            int mult = 0;
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                mult = mult + matrix_1[k, j] * matrix_2[j, i];
            }
            matrix[k, i] = mult;
        }
    } 
    return(matrix);
 }

const int rows = 3;
const int columns = 3;
const int leftRange = 1;
const int rightRange = 9;

Console.WriteLine("Первая матрица");
int[, ] matrix_1 = GetRandomMatrix(rows, columns, leftRange, rightRange);
PrdoubleMatrix(matrix_1);
Console.WriteLine();

Console.WriteLine("Вторая матрица");
int[, ] matrix_2 = GetRandomMatrix(rows, columns, leftRange, rightRange);
PrdoubleMatrix(matrix_2);
Console.WriteLine();

 Console.WriteLine("Произведение матриц");
 int[, ] matrix_3 = MultiplicationMatrix(matrix_1, matrix_2, rows, columns);
 PrdoubleMatrix(matrix_3);