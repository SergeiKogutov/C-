// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(N);
printArray(arr);
paritycheck(arr);

void printArray(int[] Array)
{
    foreach (int i in Array)
    {
        Console.Write($"{i}, ");
    }
    Console.WriteLine("");
}
int[] FillArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}
void paritycheck(int[] Array)
{
    int counter = 0;
    for (int i = 0; i < N; i++)
    {
        if (Array[i] % 2 == 0) counter++;
    }
    Console.WriteLine($"В этом массиве количество чётных чисел равно {counter}.");
} 