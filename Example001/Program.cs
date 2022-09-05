// Console.WriteLine("Введите два числа. Я скажу, какое из них больше! ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > b) 
// {
//     Console.WriteLine("Первое число больше");
// }

// else 
// {
//     Console.WriteLine("Второе число больше");
// }

// int n=9;
// void PrintArray(int[] arr)
//     {
//     for(int i = 0; i < n; i++)
//         {     
//         if (i!=arr.Length-1)  Console.Write($"{arr[i]}, ");
//         else Console.WriteLine($"{arr[i]}"); 
//         } 
//     }

// int [] numbers = new int[n];
// for(int i = 0; i < n; i++)
//     {
//         numbers[i] = new Random().Next(0,100);
//     }
//     PrintArray(numbers);
//         Console.WriteLine();
//         int buf;
//         for(int i = 0; i < n/2; i++)
//            {
//                buf = numbers[i];
//                numbers[i] = numbers[n-1-i];
//                numbers[n-1-i] = buf;
//            }
//            PrintArray(numbers);

// Задача 40: Напишите программу, которая принимает на вход три 
// числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона 
// треугольника меньше суммы двух других сторон.

// Console.Write("введите целое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите целое число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите целое число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a+b<c || a+c<b || b+c<a) Console.Write("такова триугольника не бывает!");
// else Console.Write("такой триугольника существует!");

// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// int ConvertToBinary(int number) 
// {
//     int result = 0;
//     int order = 1;                      
//     while (number > 0) 
//     {                
//         result += (number % 2) * order; 
                                        
                                        
//         order *= 10;
//         number /= 2;
//     }
//     return result;
// }
// Console.Write(ConvertToBinary(45));

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// int c = 0;
// string b = String.Empty;
// while (a >= 1)
// {
//     c = a%2;
//     b = b+Convert.ToString(c);
//     a = a/2;
// }
// char [] b2 = b.ToCharArray();
// Array.Reverse(b2);
// Console.WriteLine(b2);

// Задача 44: Не используя рекурсию, выведите первые N чисел 
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


// Console.Write("Введите количество чисел, необходимых для вывода: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int a = 0, b =1, c =0;

// if (n==0) Console.Write(a);
// else if (n == 1) Console.Write(a + " " + b);
// else 
// {
//     Console.Write(a + " " + b + " ");
//     for (int i = 2; i < n; i++)
//     {
//         c = a+b;
//         Console.Write(c + " ");
//         a =b;
//         b =c;
//     }
// }
// Console.WriteLine();
