// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B. Без модуля Math, используем цикл for.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double PowNun(int a, int b)
{
    double result = 1;
    if (a < 0 || b < 0)
    return 0;
    
    for (int i = 1; i <= b; i++)
    {
            result = result* a;
    }
    return result;
}

Console.WriteLine("Введите число");
int num_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень");
int num_2 = int.Parse(Console.ReadLine());

Console.WriteLine(PowNun(num_1, num_2));
