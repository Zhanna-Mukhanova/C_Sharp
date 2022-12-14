/*  Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


int Count(int size) {
    int counter = 0;
    for (int i = 0; i < size; i++)
    {
        int number = int.Parse(Console.ReadLine());
        if(number>0)
            counter++;
    }
    return counter;
}

Console.WriteLine("Введите M");
int m = int.Parse(Console.ReadLine());
int count = Count(m);
Console.WriteLine("Количество чисел больше 0");
Console.WriteLine(count);