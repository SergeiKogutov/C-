// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) array[i, j] = new Random().Next(1, 10);
    }
    return array;

}
int FindingTheElement(int[,] array, int m, int n)
{
    int resolt = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == m && j == n) resolt = array[i,j];
        }
    }
    if (resolt == 0) Console.WriteLine("такого элимента нет.");
    return resolt;
}
Console.Write("Введите строку: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] mas = FillArray(5, 5);
PrintArray(mas);
Console.WriteLine();
int x = FindingTheElement(mas,m,n);
if (x != 0) Console.WriteLine($"Элементом на позиции [{m},{n}] является {x}.");
Console.WriteLine();