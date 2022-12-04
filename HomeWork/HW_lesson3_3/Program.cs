// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Koub(int N)
{
    int b = 0;
    
    while (b < N)
    {
        double Coube = Math.Pow((b + 1), 3);
        Console.Write($" {Coube} ");
        b = b + 1;
    }
    Console.WriteLine();
}
 Koub(5);

 Koub(50);

 Koub(3);

 Koub(30);