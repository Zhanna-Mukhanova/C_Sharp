// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        int random = new Random().Next(100, 999);
        array[i] = random;
        Console.Write($"{random} ");
    }
    Console.WriteLine();
    return array;
}

int CountEven(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

Console.WriteLine(countEven(createArray(10000)));
