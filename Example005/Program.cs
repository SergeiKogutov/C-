
// void PrintNumbers(int num1, int num2)
// {
//     for (int i=num1;i<num2+1;i++) Console.Write($"{i}, ");
//     Console.WriteLine();
// }

// PrintNumbers(2,8);
// PrintNumbers(1,18);
// PrintNumbers(2,5);
// PrintNumbers(2,13);
//  Напишите программу, которая выводит случайное число из отрезка [10, 99] 
//  и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

// int x = new Random() .Next(10, 100);
// Console.WriteLine($" случайное число сгенерировалось {x} ");
// int x1 = x/10;
// int x2 = x%10;
// if (x1>x2) Console.WriteLine(x1);
// else Console.WriteLine("   " +x2);



void DeleteSecondNumber1()
{
    Console.WriteLine("Enter number: ");
    string number = Console.ReadLine();
    
    for (int i = 0; i < number.Length; i++)
    {
        if (i != 1)
        {
            Console.Write(number[i]);
        }
    }
    Console.WriteLine();
}

DeleteSecondNumber1();

