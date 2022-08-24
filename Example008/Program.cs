Console.WriteLine("введите номер дня нидели: ");
int x = Convert.ToInt32( Console.ReadLine());

if (x==1)
{
    Console.WriteLine(x+" это пнидельник, это не выходной. ");
}
else if (x==2)
{
    Console.WriteLine(x+" это вторник, это не выходной. ");
}
else if (x==3)
{
    Console.WriteLine(x+" это среда, это не выходной. ");
}
else if (x==4)
{
    Console.WriteLine(x+" это четверг, это не выходной. ");
}
else if (x==5)
{
    Console.WriteLine(x+" это пятница, это не выходной. ");
}
else if (x==6)
{
    Console.WriteLine(x+" это суббота, это выходной. ");
}
else if (x==7)
{
    Console.WriteLine(x+" это воскрисенье, это выходной. ");
}
else
{
   Console.WriteLine(" такова дня недели нет  ");
}