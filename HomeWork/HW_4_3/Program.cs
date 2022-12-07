// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//  1, 2, 5, 7, 19, 1, 2, 8 -> [1, 2, 5, 7, 19]
//  6, 1, 33 -> [6, 1, 3]

int[] Array8()
{
    int[] result = new int[8];

    for (int i = 0; i < 8; i++)
        result[i] = new Random().Next(1,1000);
    return result;
}

void Print(int[] array)

{
    for (int i = 0; i < 8; i++)
            Console.Write($"{array[i]} "); 
}

int[] array_1 = Array8();
Print(array_1);