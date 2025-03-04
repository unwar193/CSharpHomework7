﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/* m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.Clear();
 
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);

double[,] array = new double[m, n];
FillArray(array);
PrintArray(array);

void FillArray (double[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = Math.Round(generator.Next(-10, 11) + generator.NextDouble(), 1);
            }        
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"| {array[i,j]} |");
            }
        Console.WriteLine();
    }
    Console.WriteLine();
}
