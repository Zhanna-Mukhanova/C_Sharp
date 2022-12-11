/*
Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] CreateDoubleArray(int size, int from, int to)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        double random = new Random().NextDouble() * (from + to) - from;
        array[i] = random;
        Console.Write($"{random} ");
    }
    Console.WriteLine();
    return array;
}

double Difference(double[] array){
    double max = array[0];
    double min = array[0];
    int size = array.Length;
    for (int i = 0; i < size; i++){
        double a = array[i];
        if (a < min)
        {
            min = a;
        }
        if( a > max)
        {
            max = a;
        }
    }
    double difference = max - min;
    Console.WriteLine($"{difference} ");
    return difference;
}

Difference(CreateDoubleArray(5, 100, 1000));