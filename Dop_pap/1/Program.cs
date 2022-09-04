// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Metod(int a, int b)
{
    int c = 1;
    for (int i = 1; i <= b; i++)
    {
        c = c * a;
    }
    return c;
}

Console.Write("Введите целое число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int c = (Metod(a, b));
Console.WriteLine($"{a} в степени {b} = {c}");