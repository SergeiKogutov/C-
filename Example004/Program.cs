// Console.WriteLine("введите число : ");
// int a = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while (i <= a)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
//     i = i +1;
// }

// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.



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

// int[,] SwopArray(int[,] array)
// {
//     int temp = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         temp = array[0,j];
//         array[0,j] = array[array.GetLength(0)-1,j];
//         array[array.GetLength(0)-1,j] = temp; 
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
// SwopArray(mas);
// PrintArray(mas);


// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это 
// невозможно, программа должна вывести сообщение для пользователя.

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
//         for (int j = 0; j < n; j++) array[i, j] = new Random().Next(0, 10);
//     }
//     return array;

// }

// int[,] ChangeMatrix(int[,] matrix)
// {
//     int[,] table = new int[matrix.GetLength(1), matrix.GetLength(0)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             table[j, i] = matrix[i, j];
//         }
//     }
//     return table;
// }

// Console.Write("Введите количество строк двумерного массива ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов  двумерного массива ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] mas = FillArray(m, n);
// PrintArray(mas);
// Console.WriteLine();
// mas = ChangeMatrix(mas);
// PrintArray(mas);


// int[,] array = FillArray(5, 5);
// PrintArray(array);

// void printArray(int[] Array)
// {
//     foreach (int i in Array)
//     {
//         Console.Write($"{i}, ");
//     }
//     Console.WriteLine("");
// }

// int[] arr(int[,] array)
// {
//     int[] count = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             count[array[i,j]]++;
//         }
//     }
//     return count;
// }

// int[] count = arr(array);
// printArray(count);

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
//         for (int j = 0; j < n; j++) array[i, j] = new Random().Next(0, 100);
//     }
//     return array;

// }

// int[,] ax(int[,] array)
// {
//     int min = array[0,0];
//     int minIndex = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if ( min > array[i,j]) min = array[i,j];

//         }  
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

// PrintArray(mas);