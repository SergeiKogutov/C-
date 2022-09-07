// Console.WriteLine("Введите три числа. Я скажу, какое из них больше! ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());
// int max = a;

// if (max < b)
// {
//     max = b;
// }

// if (max < y)
// {
//     max = y;
// }

// Console.WriteLine(max + " самое большое из трёх ");


int[] RandomArray(int size, int minValue, int maxValue) {
    int[] result = new int[size];
    for (int i = 0; i < size; ++i) {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}

void PrintArray(int[] array) {
    for(int i = 0; i < array.Length - 1; ++i) {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

void Reverse(int[] array) {
    for (int i = 0; i < array.Length / 2; ++i) {
        int temp = array[i];
        array[i] = array[array.Length - 1 -i];
        array[array.Length - 1 -i] = temp;
    }
}

void Task1() {
    int[] arr = RandomArray(6, 1, 100);
    PrintArray(arr);
    Reverse(arr);
    PrintArray(arr);
}

bool IsTrianglePossible(int a, int b, int c) {
    return (a < b + c && b < a + c && c < a + b);
}

void Task40() {
    Console.Write("Введите первую сторону треугольника: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите вторую сторону треугольника: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третью сторону треугольника: ");
    int c = Convert.ToInt32(Console.ReadLine());
    Console.Write($"{a}, {b}, {c} - треугольник ");
    if (!IsTrianglePossible(a, b, c)) {
        Console.Write("не ");
    }
    Console.WriteLine("возможен.");
}

int ConvertToBinary(int number) {
    int result = 0;
    int order = 1;                      // Переменная для перехода на следующую цифру числа в двоичной записи
    while (number > 0) {                
        result += (number % 2) * order; // Записываем в результирующую переменную следующую цифру 
                                        // (Каждая цифра двоичной записи - остаток от деления на 2,
                                        // умножение на order позволяет записать следующую цифру отдельно,
                                        // вместо того, чтобы прибавлять к первому числу)
        order *= 10;
        number /= 2;
    }
    return result;
}



void Task42() {
    Console.Write("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{x} -> {ConvertToBinary(x)}");
}

//Task40();
Task42();