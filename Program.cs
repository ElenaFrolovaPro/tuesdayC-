// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Console.WriteLine("Необходимо указать размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];

// FillArray(numbers);
// Console.WriteLine("Анализируемый массив: ");
// PrintArray(numbers);
// int count = 0;

// for (int j = 0; j < numbers.Length; j++)
// if (numbers[j] % 2 == 0)
// count++;

// Console.WriteLine($"Из {numbers.Length} чисел, {count} являются четными");

// void FillArray(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.WriteLine();
// }


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Необходимо указать размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];

// FillArray(numbers);
// Console.WriteLine("Анализируемый массив: ");
// PrintArray(numbers);
// int sum = 0;

// for (int j = 0; j < numbers.Length; j+=2)
//     sum = sum + numbers[j];

//     Console.WriteLine($"в массиве чисел {numbers.Length}, сумма элементов из нечетных позиций = {sum}");

// void FillArray(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(1,10);
//         }
// }
// void PrintArray(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.WriteLine();
// }


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и
//  минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Console.WriteLine("Необходимо указать размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// FillArray(numbers);
// Console.WriteLine("Анализируемый массив: ");
// PrintArray(numbers);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int j = 0; j < numbers.Length; j++)
// {
//     if (numbers[j] > max)
//         {
//             max = numbers[j];
//         }
//     if (numbers[j] < min)
//         {
//             min = numbers[j];
//         }
// }

// Console.WriteLine($"в массив чисел {numbers.Length} чисел. Максимум = {max}, минимум = {min}");
// Console.WriteLine($"разница между максимум и минимум значением = {max - min}");

// void FillArray(double[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//         }
// }
// void PrintArray(double[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
    
//     Console.WriteLine();
// }






// // Задача 19

// // Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// // является ли оно палиндромом. Через строку решать нельзя.

// // 14212 -> нет

// // 12821 -> да

// // 23432 -> да

//  void palindrom()
//         {
//         //int number = new Random().Next(1, 100000); for random number!!

//         Console.Write("необходимо ввести пятизначное число");
//         int number = Convert.ToInt32(Console.ReadLine()); 
//         int number1 = number / 10000 % 10;
//         int number2 = number / 1000 % 10;
//         int reverse1 = number / 10 % 10;
//         int reverse2 = number % 10;
//         int noll = number / 10000;
        
//             if (noll < 1 || noll > 9){
//             Console.WriteLine(number + "введено не пятизначное число");
//             }
//             else if  (number1 == reverse2 && number2 == reverse1){
//             Console.WriteLine(number + "Введенное число - палиндром");
//             }
//             else
//             {
//             Console.WriteLine(number + "Введенное число не палиндром");
//             }
            
//         }
//         for (int i = 0; i < 10; i++)
//         { 
//             palindrom();
//             break;
//     }

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
// ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите x 1 точки");

// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите y 1 точки");

// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите z 1 точки");

// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите x 2 точки");

// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите y 2 точки");

// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите z 2 точки");

// int z2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(DistancePount(x1, y1, x2, y2, z1, z2));

// // теорема пифагора d = Vsqrt((x2-x1)^2 + (y2-y1)^2 + (z1-z2)^2)

// double DistancePount(int x1, int y1, int x2, int y2, int z1, int z2)

// {

//     double result1 = (x2 - x1)*(x2 - x1);
//     double result2 = (y2 - y1)*(y2 - y1);
//     double result3 = (z2 - z1)*(z2 - z1);

//     double result = Math.Sqrt(result1 + result2 + result3);

//     return result;
// }

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//  Console.Write("Введите число: ");
//  int number = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= number; i++)
// {
//     Console.Write($"{i * i * i}, ");
// }









// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
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

// if(a%2 == 1)
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

// Console.Write("Все четные числа от 1 до " +a + " это: ");
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
