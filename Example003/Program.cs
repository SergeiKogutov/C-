// Console.WriteLine("введите число : ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a % 2==0)
// {
//     Console.WriteLine("это число чётное. ");
// }

// else 
// {
//     Console.WriteLine("это число нечётное. ");
// }

// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// {

//     void PrintArray(int[,] table)
//     {
//         for (int i = 0; i < table.GetLength(0); i++)
//         {
//             for (int j = 0; j < table.GetLength(1); j++)
//             {
//                 Console.Write(table[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }


//     int[,] FillArray(int m, int n)
//     {
//         int[,] array = new int[m, n];
//         for (int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++) array[i, j] = new Random().Next(1, 100);
//         }
//         return array;

//     }
//     Console.Write("Введите количество строк двумерного массива ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов  двумерного массива ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     int[,] mas = FillArray(m, n);
//     PrintArray(mas);



// }

// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
// (a)m*n=m+n



// void PrintArray(int[,] table)
// {
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             Console.Write(table[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++) array[i, j] = i + j;
//     }
//     return array;

// }
// Console.Write("Введите количество строк двумерного массива ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов  двумерного массива ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] mas = FillArray(m, n);
// PrintArray(mas);

// int max = mas[0,0];
// int imax = 0; 
// int jmax = 0;
// int temp = 0;
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         if (max< mas[i,j])
//         {
//             max = mas[i,j];
//             imax = i;
//             jmax = j;
//         }
//     }
// }
// temp = mas[imax,jmax];
// mas[m-1,n-1] = max;


// Console.Write("Задайте массив, введя количество его элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int maxPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] > array[maxPosition]) maxPosition = j;
//             }
//         int temporary = array[i];
//         array[i] = array[maxPosition];
//         array[maxPosition] = temporary;
//     }
// }

// PrintArray(array);
// SelectionSort(array);
// PrintArray(array);

// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса 
// нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// void PrintArray(int[,] table)
// {
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             Console.Write(table[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++) array[i, j] = new Random().Next(1, 11);
//     }
//     return array;

// }
// Console.Write("Введите количество строк двумерного массива ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов  двумерного массива ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] mas = FillArray(m, n);
// PrintArray(mas);
// Console.WriteLine();
// int[,] SquareOddArray(int[,] mas)
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             if (i%2 == 1 && j%2 ==1) mas[i,j] = mas[i,j] * mas[i,j];
//         }
//     }
//     return mas;
// }
// SquareOddArray(mas);
// PrintArray(mas);




// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на 
// главной диагонали (с индексами (0,0); (1;1) и т.д.


// void PrintArray(int[,] table)
// {
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             Console.Write(table[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++) array[i, j] = i + j;
//     }
//     return array;

// }
// Console.Write("Введите количество строк двумерного массива ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов  двумерного массива ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] mas = FillArray(m, n);
// PrintArray(mas);
// void SumArray(int[,] mas)
// {
//     int sum = 0;
//         for (int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 if (i==j) sum = sum + mas[i,j];
//             }
//         }
//     Console.WriteLine($"сумма элементов на диагонали равна {sum}");
// }
// SumArray(mas);