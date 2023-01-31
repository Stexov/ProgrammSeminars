﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​m = 3, n = 4

double[,] GetRandomMatrix(int rows, int column, int leftRange, int rightRange)
{
    double[, ] matrix = new double[rows, column];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange)/0.4;
        }
    } 
    return(matrix);
}

void PrdoubleMatrix(double[,] matrix)
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
const int rows = 3;
const int columns = 4;
const int leftRange = -100;
const int rightRange = 100;

double[, ] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
PrdoubleMatrix(array);