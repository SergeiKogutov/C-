// Задача 21
// Напишите программу, которая принимает на 
// вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53   (X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2).

{
    double Distance3d()
    {
        Console.Write("введите x первой точки: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("введите y первой точки: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("введите z первой точки: ");
        double z1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("введите x второй точки: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("введите y второй точки: ");
        double y2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("введите z второй точки: ");
        double z2 = Convert.ToDouble(Console.ReadLine());
        //sqrt()
        double res;
        res = Math.Sqrt ((x2-x1)*(x2-x1) + (y2-y1) * (y2-y1) + (z2-z1) * (z2-z1));
        return res;
    }
    try
        {
        Console.WriteLine(Distance3d());
        }
        catch
        {
        Console.WriteLine("надо было вводить числа.");
        }
}
