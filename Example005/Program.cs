﻿
// void PrintNumbers(int num1, int num2)
// {
//     for (int i=num1;i<num2+1;i++) Console.Write($"{i}, ");
//     Console.WriteLine();
// }

// PrintNumbers(2,8);
// PrintNumbers(1,18);
// PrintNumbers(2,5);
// PrintNumbers(2,13);
//  Напишите программу, которая выводит случайное число из отрезка [10, 99] 
//  и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

// int x = new Random() .Next(10, 100);
// Console.WriteLine($" случайное число сгенерировалось {x} ");
// int x1 = x/10;
// int x2 = x%10;
// if (x1>x2) Console.WriteLine(x1);
// else Console.WriteLine("   " +x2);



// void DeleteSecondNumber1()
// {
//     Console.WriteLine("Enter number: ");
//     string number = Console.ReadLine();

//     for (int i = 0; i < number.Length; i++)
//     {
//         if (i != 1)
//         {
//             Console.Write(number[i]);
//         }
//     }
//     Console.WriteLine();
// }

// DeleteSecondNumber1();

// 12. Напишите программу, которая будет принимать на 
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// int PrintDigit()
// {
//     int x = new Random() .Next(10, 100);
//     Console.WriteLine($" случайное число сгенерировалось {x} ");
//     int x1 = x/10;
//     int x2 = x%10;
//     if (x1>x2) return x1;
//     else return x2;
// }

// Console.WriteLine (PrintDigit()*100);

// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли наименьшее 
// число кратным наибольшему. Если  наибоьшее не кратно 
// наименьшему, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.WriteLine("Введите целое число:  ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе целое число:  ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a%b ==0) Console.WriteLine(a+ " кратно " +b);
// else Console.WriteLine( $"{a} не кратно {b} остаток {a%b}");


// Console.WriteLine("Введите первое целое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе целое число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// string Multiplicity(int num1, int num2)
// {
//     string multiplicity = String.Empty;
//     int max = num1;
//     int min = num2;

//     if (num2 > num1)
//     {
//         max = num2;
//         min = num1;
//     }
//     if (max % min == 0)
//     {
//         multiplicity = $"Число {max} кратно {min}";
//     }
//     else
//     {
//         multiplicity = $"Число {max} не кратно {min}, остаток {max % min}";
//     }
//     return multiplicity;
// }
// Console.WriteLine(Multiplicity(number1, number2));

// 17. Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
// выдаёт номер четверти плоскости, в которой находится эта точка.

// {
//     int GetNum4()
//     {
//         Console.Write("введите координату x: ");
//         int x = int.Parse(Console.ReadLine());
//         Console.Write("введите координату y: ");
//         int y = int.Parse(Console.ReadLine());
//         int res;
//         if ( x>0 && y>0) res=1;
//         else if ( x<0 && y>0) res=2;
//         else if ( x<0 && y<0) res=3;
//         else if ( x>0 && y<0) res=4;
//         else res=0;
//         return res;
//     }
//     try
//         {
//         Console.WriteLine(GetNum4());
//         }
//         catch
//         {
//         Console.WriteLine("надо было вводить целые числа.");
//         }
// }

// для дробных чисел.
// {
//     double GetNum4()
//     {
//         Console.Write("введите координату x: ");
//         double x = Convert.ToDouble(Console.ReadLine());
//         Console.Write("введите координату y: ");
//         double y = Convert.ToDouble(Console.ReadLine());
//         int res;
//         if ( x>0 && y>0) res=1;
//         else if ( x<0 && y>0) res=2;
//         else if ( x<0 && y<0) res=3;
//         else if ( x>0 && y<0) res=4;
//         else res=0;
//         return res;
//     }
//     try
//         {
//         Console.WriteLine(GetNum4());
//         }
//         catch
//         {
//         Console.WriteLine("надо было вводить число.");
//         }
// }


// Задача 18: Напишите программу, которая по заданному 
// номеру четверти, показывает диапазон возможных 
// координат точек в этой четверти (x и y).

// {
//     string GetCoords()
//     {
//         Console.Write("введите номер четверти: ");
//         int num = int.Parse(Console.ReadLine());
//         string coords = "0" ;
//         if (num == 1) coords= "x > 0, y > 0";
//         else if ( num == 2) coords="x < 0, y > 0";
//         else if ( num == 3) coords="x < 0, y < 0";
//         else if ( num == 4) coords="x > 0, y < 0";
//         return coords;
//     }
//     try
//         {
//         Console.WriteLine(GetCoords());
//         }
//         catch
//         {
//         Console.WriteLine("надо было вводить целые число от 1 до 4.");
//         }
// }


// Задача 21: Напишите программу, которая принимает 
//на вход координаты двух точек и находит расстояние 
//между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21   ..AB = √(xb - xa)2 + (yb - ya)2

// {
//     double Distance2d()
//     {
//         Console.Write("введите координату x: ");
//         double x1 = Convert.ToDouble(Console.ReadLine());
//         Console.Write("введите координату y: ");
//         double y1 = Convert.ToDouble(Console.ReadLine());
//         Console.Write("введите координату x второго числа: ");
//         double x2 = Convert.ToDouble(Console.ReadLine());
//         Console.Write("введите координату y второго числа: ");
//         double y2 = Convert.ToDouble(Console.ReadLine());
//         //sqrt()
//         double res;
//         res = Math.Sqrt ((x2-x1)*(x2-x1) + (y2-y1) * (y2-y1));
//         return res;
//     }
//     try
//         {
//         Console.WriteLine(Distance2d());
//         }
//         catch
//         {
//         Console.WriteLine("надо было вводить числа.");
//         }
// }


//Задача 22: Напишите программу, которая
//    принимает на вход число (N) и выдаёт
//    таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

// {
//     void SquareTableN()
//     {
//         Console.Write("Введите число ");
//         int N = Convert.ToInt32(Console.ReadLine());
//         int[] answer = new int[N];
//         if (N > 0)
//         {
//             for (int i = 1; i < (N + 1); i++)
//             {
//                 answer[i - 1] = (i * i);
//             }
//         }
//         else
//         {
//             Console.Write("Надо было вводить положительные числа");
//         }
//         var str = string.Join(" ", answer);
//         Console.WriteLine(str);
//     }

//     try
//     {
//         SquareTableN();
//     }
//     catch
//     {
//         Console.Write("Надо было вводить числа");
//     }
// }


// Console.Write("введите ваше имя ");
// string name = Console.ReadLine();

// switch (name)
//     {
//     case "Bob":
//         Console.WriteLine("Здарова, Bob");
//         break;
//     case "Tom":
//         Console.WriteLine("Приве, Tom");
//         break;
//     case "Sam":
//         Console.WriteLine("Как дела, Sam");
//         break;
//     default:
//         Console.WriteLine("Приятно познакомиться, "+name);
//         break;
//     }


// Задача 24: Напишите программу, которая принимает 
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int[] array={5, 6, 67, 54, 32, 23, 12, 12, 234};
// foreach (int i in array) Console.Write($"{i}, ");
// Console.WriteLine();
// for (int i=0; i<array.Length; i++) Console.Write($"{array[i]}, ");
// Console.WriteLine();


// Задача 30: Напишите программу, которая выводит 
// массив из N элементов, заполненный случайными 
// целыми числами. N - целое число и задается с клавиатуры

// Console.WriteLine("Введите целое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] numbers = new int[n];
// for(int i = 0; i < n; i++)
// {
//     numbers[i] = new Random().Next(1,100);
//     if (i!=n-1)  Console.Write($"{numbers[i]}, ");
//     else Console.WriteLine($"{numbers[i]}");
// }

//Задача 30: Напишите программу, 
//    которая выводит массив из N элементов,
//    заполненный случайными целыми числами. 
//    N - целое число и задается с клавиатуры.


// Random rd = new Random();
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] arr = FillArray(N);

// int[] FillArray(int number)
// {
//     int[] array = new int[number];
//     for (int i = 0; i < N; i++)
//     {
//         array[i] = rd.Next(1, 100);
//     }
//     return array;
// }

// void printArray(int[] Array)
// {
//     foreach (int i in Array)
//     {
//         Console.Write($"{i}, ");
//     }
//     Console.WriteLine("");
// }

// double[] zadacha(int[] array)
// {
//     //max
//     //int N = array.Length;
//     int max = array[0];
//     int maxIndex = 0;
//     for (int i = 0; i < N; i++)
//         {
//             if (array[i] > max)
//             {
//                 max = array[i];
//                 maxIndex = i;
//             }
//         }

//     //min
//     int min = array[0];
//     int minIndex = 0;
//     for (int i = 0; i < N; i++)
//     {
//         if (array[i] < max)
//         {
//             min = array[i];
//             minIndex = i;
//         }
//     }

//     //average
//     double average = 0;
//     foreach(int i in array)
//     {
//         average += i;
//     }
//     average = average / array.Length;

//     double[] answer = {maxIndex, minIndex, average, max, min};
//     return answer;
// }
// //printArray(arr);
// double[] answer = zadacha(arr);
// Console.WriteLine($" max индекс = {answer[0]}");
// Console.WriteLine($" min индекс = {answer[1]}");
// Console.WriteLine($" average = {answer[2]}");
// Console.WriteLine($" max = {answer[3]}");
// Console.WriteLine($" min = {answer[4]}");


// Задача 31: Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. Найдите сумму 
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int [] numbers = new int[12];
// for(int i = 0; i < 12; i++)
// {
//     numbers[i] = new Random().Next(-9,10);
//     if (i!=12-1)  Console.Write($"{numbers[i]}, ");
//     else Console.WriteLine($"{numbers[i]}");
// }
// int sum_p = 0;
// int sum_n = 0;
// string s = " ";
// foreach (var item in numbers)
// {
//     if (item>0) 
//     {
//         sum_p+=item;
//         s+=$"{item} + ";
//     }
//     else sum_n+=item;
// }
// Console.WriteLine($"Сумма положительных чисел {s} равна {sum_p}");
// Console.WriteLine($"Сумма отрецательных чисел равна {sum_n}");


// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие 
// отрицательные, и наоборот.
// [-4, -8, 8, 2] - [4, 8, -8, -2]

// int [] numbers = new int[6];
// for(int i = 0; i < 6; i++)
// {
//     numbers[i] = new Random().Next(-10,11);
//     if (i!=6-1)  Console.Write($"{numbers[i]}, ");
//     else Console.WriteLine($"{numbers[i]}");
// }
// Console.WriteLine();
// for (int i = 0; i < 6; i++)
// {
//     if(numbers[i]> 0)
//     {
//         numbers[i] = -numbers[i];
//         Console.Write($"{numbers[i]}, ");
//     }
//     else
//     { 
//         numbers[i] = numbers[i] * -1;
//         Console.Write($"{numbers[i]}, ");
//     }
// }

// Задача 33: Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// int [] numbers = new int[6];
// for(int i = 0; i < 6; i++)
// {
//     numbers[i] = new Random().Next(-10,11);
//     if (i!=6-1)  Console.Write($"{numbers[i]}, ");
//     else Console.WriteLine($"{numbers[i]}");
// }
// Console.WriteLine();

// Console.Write("Write numbers: ");
// int x = Convert.ToInt32(Console.ReadLine());
// bool faid = false;
// foreach (var item in numbers)
// {
//     if (x == item)
//     {
//         faid = true;
//         break;
//     }
// }
// if(faid) Console.WriteLine("yes");
// else Console.WriteLine("no");

// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат 
// в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении 
// сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


// int [] numbers = new int[15];
// for(int i = 0; i < 15; i++)
// {
//     numbers[i] = new Random().Next(0,1000);
//     if (i!=15-1)  Console.Write($"{numbers[i]}, ");
//     else Console.WriteLine($"{numbers[i]}");
// }
// Console.WriteLine();
// int count = 0;
// for (int i = 0; i < 15; i++)
// {
//     if (numbers[i]> 9 && numbers[i]<100)
//     {
//         count= count + 1;
//     }
// }
// Console.WriteLine($"количество чисел от 10 до 100 : {count} .");


// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний 
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21б


// Console.Write("Введите размер массива: ");   
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];    //Создали массив заданной размерности
// for (int i = 0; i < N; ++i)  // Заполняем массив случайными числами от 1 до 9
// {
//     array[i] = new Random().Next(1, 10);
// }
// Console.Write("[");                     //Красиво выводим массив
// for (int i = 0; i < N - 1; ++i)
// {
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine(array[N - 1] + "]");
// int[] result = new int[N / 2 + N % 2]; //Создаём массив для хранения результата 
//                                        //(При чётном размер будет равен размеру изначального массива, делённому на 2,
//                                        //при нечётном, к этому будет добавлена единица.)

// for(int i = 0; i < array.Length / 2; ++i) //Фиксируем результаты произведений всех пар элементов
// {
//     result[i] = array[i] * array[array.Length - 1 - i];
// }
// if(array.Length % 2 == 1)  // Фиксируем оставшийся элемент при нечётном количестве элементов
// {
//     result[array.Length / 2] = array[array.Length / 2];
// }
// for (int i = 0; i < result.Length - 1; ++i) //Выводим на экран результирующий массив
// {
//     Console.Write(result[i] + " ");
// }
// Console.WriteLine(result[result.Length - 1]);