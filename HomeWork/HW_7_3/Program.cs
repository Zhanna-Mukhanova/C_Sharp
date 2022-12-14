/*
Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] array = createArray(5,10);
Print(array);
PrintAverage(array);

void PrintAverage(int[,] arr){
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
    Console.Write("Среднее арифметическое каждого столбца: ");
    for(int j = 0; j < col_size; j++) 
    {
        double sum = 0;
        for(int i = 0; i < row_size; i++){
            sum = sum + arr[i,j]; 
        }
        double avg = sum / col_size;
        Console.Write($" {avg}");
    }
    Console.WriteLine();
}

int[,] createArray(int m, int n){
    int[,] array = new int[m, n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            array[i,j] = new Random().Next(0, 20);
        }
    }
    return array;
}

void Print(int[,] arr){
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
    for(int i = 0; i < row_size; i++) 
    {
        for(int j = 0; j < col_size; j++){
            Console.Write($" {arr[i,j], 4} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}