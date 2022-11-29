Console.WriteLine("Введите число A"); 
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B"); 
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
int min = number2;


if (max < number2) 
{
    max = number2;
    min = number1;
    Console.Write("max =");
    Console.WriteLine(max );

    Console.Write("min =");
    Console.WriteLine( min );

}

else if (max > number2)
{
    max = number1;
    min = number2;
    Console.Write("max =");
    Console.WriteLine(max );

    Console.Write("min =");
    Console.WriteLine( min );

}
else if (number1 == number2)
{
    Console.WriteLine("Числа одинаковые");
}

