/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 26
[-4, -6, 4, 6] -> 0
*/

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

int SumOddNumbers(int[] array)
{
    int size = array.Length;
    int summa = 0; 
    for(int i = 0; i < size; i = i + 2)
    {
        summa = summa + array[i];
    }

    return summa;
}

Console.WriteLine(SumOddNumbers(CreateArray(4)));