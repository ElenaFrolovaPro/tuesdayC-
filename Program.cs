// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int [,] matrix = new int [4, 4];
// CreateMatrix(matrix);
// PrintMatrix(matrix);
// GetOrderMatrix(matrix);

// void GetOrderMatrix(int[,] matrix)
// {

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1) - 1; j++)
// {
//     for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//     {
//         if (matrix[i, k] < matrix [i, k+1])
//         {
//             int order = 0;
//             order = matrix[i, k];
//             matrix[i, k] = matrix[i, k + 1];
//             matrix[i, k + 1] = order;

//         }
//     }
// }
// }
// }
// Console.WriteLine();

// PrintMatrix(matrix);

//  void CreateMatrix(int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(1, 10);
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


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой 
// элементов: 1 строка


// int [,] matrix = new int [4, 6];
// CreateMatrix(matrix);
// PrintMatrix(matrix);
// int minimal = 0;
// int countline = CountMinLine(matrix, 0);

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     int sum = CountMinLine(matrix, i);
//     if (countline > sum)
//     {
//         countline = sum;
//         minimal = i;
//     }
// }
// Console.WriteLine($"the minimal sum is in string {minimal + 1}");

// int CountMinLine(int[,] matrix, int i)
// {
//     int countline = matrix[i, 0];
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         countline += matrix[i,j];
//     }
//     return countline;
// }
//  void CreateMatrix(int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(1, 10);
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


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int [,] matrixfirst = new int [2, 3];
// int [,] matrixsecond = new int [3, 2];
// CreateMatrix(matrixfirst);
// CreateMatrix(matrixsecond);
// PrintMatrix(matrixfirst);
// Console.WriteLine();
// PrintMatrix(matrixsecond);
// Console.WriteLine();
// int m = 2;

// int [,] matrixresult = new int [m, m];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//         for (int k = 0; k < m; k++)
//         {
//             matrixresult[i,j] = matrixresult[i,j] + (matrixfirst[i,k] * matrixsecond[k, j]); 
//         }
//     }
// }
// PrintMatrix(matrixresult);

//  void CreateMatrix(int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(0, 10);
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

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] CreateMatrix(int row, int col, int dep, int min, int max)
// {
//     int[,,] matrix = new int[row, col, dep];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++) 
//             {
//                 matrix[i, j, k] = GetUniqueValue(matrix, min, max, i, j, k); 
//             }
//         }
//     }
//     return matrix;
// }
// Random rnd = new Random();

// int GetUniqueValue(int[,,] matrix, int min, int max, int i, int j, int k)
// {
//     int value = default;
//     bool exist = true;
//     while (exist)
//     {
//         bool tobreak = false;
//         value = rnd.Next(min, max + 1);
//         for (int i1 = 0; i1 < matrix.GetLength(0); i1++)
//         {
//             if (tobreak) { break; }
//             for (int j1 = 0; j1 < matrix.GetLength(1); j1++)
//             {
//                 if (tobreak) { break; }
//                 for (int k1 = 0; k1 < matrix.GetLength(2); k1++)
//                 {
//                     if (matrix[i1, j1, k1] == value) { tobreak = true; break; }
//                     if (i1 == i && j1 == j && k1 == k) { exist = false; }
//                 }
//             }
//         }
//     }
//     return value;
// }
// void PrintMatrix(int[,,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write("|");
//             for (int k = 0; k < matrix.GetLength(2); k++) 
//             { 
//                 Console.Write($"{matrix[i, j, k],1}({i},{j},{k})|"); 
//             }
//             Console.WriteLine();
//         }
//     }
// }

// int[,,] array3D = CreateMatrix(2, 2, 2, 10, 99);
// PrintMatrix(array3D);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] spiralMatrix = new int[4, 4];

// int def = 1;
// int i = 0;
// int j = 0;

// void CreateMatrix (int[,] matrix)
// {
//   while (def <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
//   {
//     spiralMatrix[i, j] = def;
//     def++;
//     if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
//     j++;
//     else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
//     i++;
//     else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
//     j--;
//     else
//     i--;
//   }
// }
// CreateMatrix(spiralMatrix);

// PrintMatrix(spiralMatrix);

// void PrintMatrix (int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       if (matrix[i,j] / 10 <= 0)
//       Console.Write($" {matrix[i,j]} ");

//       else Console.Write($"{matrix[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// using System;
// class Program
// {
// static int ReadInt(string prompt)
// {
//   Console.Write(prompt);
//   return Convert.ToInt32(Console.ReadLine());
// }

// static void WriteNumbers(int num)
// {
//   if (num == 0) return;
//   Console.Write(num+ " ");
//   WriteNumbers(num - 1);
// }
// static void Main(string[] args)
// {
//   WriteNumbers(ReadInt("Input a number: "));
// }
// } 

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int Prompt(string message)
// {
  
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
  
// }
// int n = Prompt("Input number m: ");
// int m = Prompt("Input number n: ");


// int SumNumbersBetween(int m, int n)
// {
//              if (m == 0) return (n * (n + 1)) / 2;       
//             else if (n == 0) return (m * (m + 1)) / 2;      
//             else if (m == n) return m;                      
//             else if (m < n) return n + SumNumbersBetween(m, n - 1); 
//             else return n + SumNumbersBetween(m, n + 1);           

// }
// SumNumbersBetween(m, n);

// Console.WriteLine(SumNumbersBetween(m, n));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Prompt(string message)
// {
//   Console.Write(message);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int Ackerman(int m, int n)
// {
//   if (m == 0) return n + 1;
//   if (m !=0 && n == 0) return Ackerman(m - 1, 1);
//   if (m > 0 && n > 0) return Ackerman(m - 1, Ackerman(m, n - 1));
//   return Ackerman(m, n);
// }

// int m = Prompt("Input number m: ");
// int n = Prompt("Input number n: ");

// Console.WriteLine($"A({m},{n}) = {Ackerman(m, n)}");