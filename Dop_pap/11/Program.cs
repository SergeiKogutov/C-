// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(double[,] table)
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
double[,] FillArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) array[i, j] = new Random().Next(1, 10);
    }
    return array;

}
void ArithmeticMeanOfColumns(double[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);

    for (int j = 0; j < m; j++)
    {
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += array[i, j];
        }
        Console.Write($"({sum / m});  ");
    }
    Console.WriteLine();
}
Console.Write("Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] mas = FillArray(m, n);
PrintArray(mas);
Console.WriteLine();
ArithmeticMeanOfColumns(mas);