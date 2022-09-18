// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Metod(int a, int b)
// {
//     int c = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         c = c * a;
//     }
//     return c;
// }

// Console.Write("Введите целое число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите целое число B: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int c = (Metod(a, b));
// Console.WriteLine($"{a} в степени {b} = {c}");

// Найти сумму всех натуральных чисел от 1 до N. N - задается пользователем.
// int SummaLoop(int N)
// {
//     int sum = 0;
//     while (N > 0)
//     {
//         sum += N;
//         N--;
//     }
//     return sum;
// }
// int SummaRec(int N)
// {
//     if (N == 0) return 0;
//     return N + SummaRec(N - 1);
// }
// Console.WriteLine(SummaLoop(5));
// Console.WriteLine(SummaRec(5));

// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// void Numbers()
// {
//     Console.Write("введите n: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     for (int i = 1; i <= n; i++)
//     {
//         Console.Write($"{i}, ");
//     }
// }
// string SummaRec(int N)
// {
//     if (N == 0) return " ";
//     return SummaRec(N - 1)  + " " +  Convert.ToString (N);
// }
// Console.Write("введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SummaRec(n));
// Numbers();

// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// string SummaRec(int M, int N)
// {
//     if (M > N) return " ";
//     return SummaRec( M, N - 1)  + " " +  Convert.ToString (N);
// }
// Console.Write("введите M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SummaRec(m, n));

// Задача 67: Напишите программу, которая будет 
// принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int SummaRec(int N)
// {
//     if (N%10 == 0) return 0;
//     return N%10 + SummaRec(N/10);
// }
// Console.Write("введите N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SummaRec(n));

// Задача 69: Напишите программу, которая на вход 
// принимает два числа A и B, и возводит число А в 
// целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


// int SummaRec(int N, int M)
// {
//     if (M == 0) return 1;
//     return N * SummaRec( N,M-1);
// }
// Console.Write("введите N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SummaRec(n,m));

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// A(m,n) =  n + 1               |  m = 0
        // { A(m- 1,1)           | m>0, n=0
        //   A(m- 1,A(m,n - 1))  | m>0, n>0


