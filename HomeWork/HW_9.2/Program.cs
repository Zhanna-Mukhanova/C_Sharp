/* Задача 2: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int PrintSum(int m, int n) {
    if (n < m){
        return 0;
    }
    return PrintSum(m, n - 1) + n;
}

Console.WriteLine("Введите число M больше 0");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N больше 0");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма чисел");
Console.WriteLine(PrintSum(m, n));