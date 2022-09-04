// Задача 27: Напишите программу, которая 
// принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите целое число : ");
int a = Convert.ToInt32(Console.ReadLine());

int SumNumber(int a)
{
    
    int x = Convert.ToString(a).Length;
    int y = 0;
    int res = 0;

    for (int i = 0; i < x; i++)
    {
      y = a - a % 10;
      res = res + (a - y);
      a = a/ 10;
    }
    return res;
}
int n = SumNumber(a);
Console.Write($"сумма цифр в этом числе = {n} ");
