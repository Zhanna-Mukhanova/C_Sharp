Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.WriteLine($"Четные числа до {N}:");
while (i <= N)
{
    if ( i % 2 == 0)
    {
        Console.WriteLine($"{i} ");
    }
    
    i=i+1;
}
