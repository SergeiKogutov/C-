
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
//             {
//                 Console.Write("Надо было вводить положительные числа");
//             }
//         var str = string.Join(" ", answer);
//         Console.WriteLine(str);
//     }
//     try
//         {
//             SquareTableN();
//         }
//         catch
//         {
//             Console.Write("Надо было вводить числа");
//         }
// }