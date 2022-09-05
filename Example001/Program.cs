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