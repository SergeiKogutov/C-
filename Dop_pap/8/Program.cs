// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 5
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void moreThanZero()
{
    Console.Write("Введите целое число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[n];
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (i == 0) Console.Write("Введите первое число: ");
        else if (i == n-1) Console.Write("Введите последние число: ");
        else Console.Write("Введите следующие число: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        if (numbers[i] > 0) count++;
    }
    foreach (int i in numbers)
    {
        Console.Write($"{i}, ");
    }
    Console.WriteLine("");
    Console.WriteLine($"вы ввели {count} чисел больше ноля.");
}
moreThanZero();