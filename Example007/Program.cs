
    Console.WriteLine("Enter number: ");
    string number = Console.ReadLine();
    
    for (int i = 0; i < number.Length; i++)
    {
        if (number.Length < 3)
        {
            Console.WriteLine("третьей цыфры нет!");
            break;
        }      
        if (i == 2)
        {
            Console.Write(number[i]);
        }
    }
    Console.WriteLine();

