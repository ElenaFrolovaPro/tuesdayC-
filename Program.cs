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