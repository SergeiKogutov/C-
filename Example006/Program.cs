
void DeleteSecondNumber1()
{
    Console.WriteLine("Enter number: ");
    string number = Console.ReadLine();
    
    for (int i = 0; i < number.Length; i++)
    {
        if (i == 1)
        {
            Console.Write(number[i]);
        }
    }
    Console.WriteLine();
}

DeleteSecondNumber1();