// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3 7 22 2 78] -> 76

Random rd = new Random();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] arr = FillArray(N);
printArray(arr);
sumMinMax(arr);

double[] FillArray(int number)
{
    double[] array = new double[number];
    for (int i = 0; i < N; i++)
    {
        array[i] = rd.Next(1, 100);
    }
    return array;
}
void printArray(double[] Array)
{
    foreach (int i in Array)
    {
        Console.Write($"{i}, ");
    }
    Console.WriteLine("");
}
void sumMinMax(double[] array)
{
    int N = array.Length;
    double max = array[0];
    for (int i = 0; i < N; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }           
        }
    Console.WriteLine($"max = {max}");

    double min = array[0];
    for (int i = 0; i < N; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }   
    }
    Console.WriteLine($"min = {min}");
    Console.WriteLine($"{max} + {min} = {max + min}");
}
