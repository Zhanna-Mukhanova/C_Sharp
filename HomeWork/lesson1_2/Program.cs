Console.WriteLine("Введите число A") ; 
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B") ; 
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число C") ; 
int number3 = Convert.ToInt32(Console.ReadLine());

int MAX = number1;

if (number1 > MAX) MAX = number1;
if (number2 > MAX) MAX = number2;
if (number3 > MAX) MAX = number3;

Console.Write("MAX = ");
Console.WriteLine(MAX);