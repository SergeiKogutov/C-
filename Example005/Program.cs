
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



// void DeleteSecondNumber1()
// {
//     Console.WriteLine("Enter number: ");
//     string number = Console.ReadLine();
    
//     for (int i = 0; i < number.Length; i++)
//     {
//         if (i != 1)
//         {
//             Console.Write(number[i]);
//         }
//     }
//     Console.WriteLine();
// }

// DeleteSecondNumber1();

// 12. Напишите программу, которая будет принимать на 
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// int PrintDigit()
// {
//     int x = new Random() .Next(10, 100);
//     Console.WriteLine($" случайное число сгенерировалось {x} ");
//     int x1 = x/10;
//     int x2 = x%10;
//     if (x1>x2) return x1;
//     else return x2;
// }

// Console.WriteLine (PrintDigit()*100);

// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли наименьшее 
// число кратным наибольшему. Если  наибоьшее не кратно 
// наименьшему, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.WriteLine("Введите целое число:  ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе целое число:  ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a%b ==0) Console.WriteLine(a+ " кратно " +b);
// else Console.WriteLine( $"{a} не кратно {b} остаток {a%b}");


Console.WriteLine("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

string Multiplicity(int num1, int num2)
{
    string multiplicity = String.Empty;
    int max = num1;
    int min = num2;
    
    if (num2 > num1)
    {
        max = num2;
        min = num1;
    }

    if (max % min == 0)
    {
        multiplicity = $"Число {max} кратно {min}";
    }
    else
    {
        multiplicity = $"Число {max} не кратно {min}, остаток {max % min}";
    }

    return multiplicity;
}
Console.WriteLine(Multiplicity(number1, number2));
