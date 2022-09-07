// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(N);
printArray(arr);
paritycheck(arr);
sumOfElementsInEvenPositions(arr);

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
        array[i] = new Random().Next(0,10);
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
void sumOfElementsInEvenPositions(int[] Array)
{
    int sum = 0;
    for (int i = 0; i < N; i++)
    {
        if (i % 2 != 0) sum = sum + Array[i];
    }
    Console.WriteLine($"сумма чисел на чётных позициях равна {sum}");
}