/*
 Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.
 b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/



void Lines2(int k1, int b1, int k2, int b2){
    double x = (double) (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Точка пересечения ({x},{y})");
}

Console.WriteLine("Введите К1");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b1");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите К2");
int k2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b2");
int b2 = int.Parse(Console.ReadLine());

Lines2(k1, b1, k2, b2);
