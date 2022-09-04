// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] NewArray()
{
    int[] numbers = new int[8];
    for(int i = 0; i < 8; i++)
    {
        numbers[i] = new Random().Next(1,11);
        if (i == 0) Console.Write($"[{numbers[i]}, ");
        else if (i!=8-1)  Console.Write($"{numbers[i]}, ");
        else Console.WriteLine($"{numbers[i]}]");
    }
    return numbers;
}

int[] n = NewArray();
