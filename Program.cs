// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// int m = ReadInt("Введите количество строк матрицы: ");
// int n = ReadInt("Введите количество столбцов матрицы: ");
// double [,] matrix = new double [m, n];
// CreateMatrix(matrix);
// PrintMatrix(matrix);

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

//  void CreateMatrix(double [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(-10, 11) / 10.0;
//         }
//     }

// }
// void PrintMatrix(double [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i,j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }


// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// int [,] matrix = new int [6, 8];
// CreateMatrix(matrix);
// PrintMatrix(matrix);
// GetPositionOfElement(matrix);

// void GetPositionOfElement(int[,] matrix)
// {
// Console.WriteLine("Введите значение элемента a: ");
// var a = int.Parse(Console.ReadLine()!);
// for (var i = 0; i < matrix.GetLength(0); i++)
// {
// for (var j = 0; j < matrix.GetLength(1); j++)
// {
// if (matrix[i, j].Equals(a))
// {
// Console.WriteLine("Позиция этого элемента: " + (i, j));
// return;
// }
// }
// }
// Console.WriteLine("Такого элемента нет");
// }

//  void CreateMatrix(int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(-10, 11);
//         }
//     }

// }
// void PrintMatrix(int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i,j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
// каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int n = 3;
// int m = 4;
// int [,] matrix = new int [n, m];
// CreateMatrix(matrix);
// PrintMatrix(matrix);

// for (int j = 0; j < matrix.GetLength(1); j++)
// {
//     double result = 0.0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     result += matrix[i, j];
// }
// result = result / n;
// Console.Write(result + "; ");
// }
// Console.WriteLine();



//  void CreateMatrix(int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(1, 11);
//         }
//     }

// }
// void PrintMatrix(int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i,j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

