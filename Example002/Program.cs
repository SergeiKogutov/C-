Console.WriteLine("Введите три числа. Я скажу, какое из них больше! ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int max = a;

if (max < b)
{
    max = b;
}

if (max < y)
{
    max = y;
}

Console.WriteLine(max + " самое большое из трёх ");