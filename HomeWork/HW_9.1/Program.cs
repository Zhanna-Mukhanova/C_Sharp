/* Задача 1: Задайте значение N. Напишите программу, 
которая выведет все четные натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "4, 2"
N = 8 -> "4, 6, 8"
*/


void PrintEven(int num) {
    if (num < 1){
        return;
    }
    else if (num % 2 == 0){
        Console.Write($" {num} ");
    }
    PrintEven(num - 1);
}
Console.WriteLine("Введите число больше 0");
int m = int.Parse(Console.ReadLine());
PrintEven(10);