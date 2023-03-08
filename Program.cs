﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());
// if( a == b)
// {
//     Console.WriteLine("Числа равны");
// }

// else if( a > b)
// {
//     Console.WriteLine("Первое число " +a + " больше второго числа " +b);

// }
// else Console.WriteLine("Второе число " +b + " больше первого числа " +a);

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
//максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;

// if( b > max)
// {
// max = b;
// }
// if ( c > max)
// {
//     max = c;
// }
// Console.WriteLine("Наибольшим из трех введенных чисел является " + max);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());

// if(a/2 == 1)
// {
//     Console.WriteLine("Введенное число - нечетное");
// }
// else
// {
//     Console.WriteLine("Введенное число - четное");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// int n = 1;
// bool not = true;

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Все четные числа от 1 до " +a + " это:");
// while (n <= a)
// {
//     if (n%2 != 1)
//     {
//         Console.Write(n + ",");
//         not = false;
//     }
//     n++;
// }
// if(not)
// {
//     Console.WriteLine(" Нет четных чисел от 1 до " +a);
// }

// Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, 
//которая принимает на вход целое число любой разрядности и на выходе показывает
// вторую цифру слева этого числа или говорит, что такой цифры нет. 
//Через строку решать нельзя.
// 456111 -> 5
// 78 -> 8
// 9146548 -> 1
// 3 -> нет

//     Console.WriteLine("Введите число");
//     int n = Convert.ToInt32(Console.ReadLine());
//     int d = OurSecondDigit(n);
//     Console.WriteLine(d);
//     Console.ReadKey();

// int OurSecondDigit(int k)
// {
//     while (k >=100) k /= 10;
//     int d = k%10;
//     return d;
// }
