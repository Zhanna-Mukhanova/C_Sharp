/* Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] CreateArray(int m, int n) {
    int[,] array = new int[m, n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            array[i,j] = new Random().Next(0, 500);
        }
    }
    return array;
}

void SortArray(int[,] arr){
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
    for(int i = 0; i < row_size; i++) 
    {
        for(int j = 0; j < col_size; j++){
            for(int t = 0; t < col_size - j - 1; t++){
                if(arr[i, t] > arr[i, t + 1]){
                    int a = arr[i, t];
                    int b = arr[i, t + 1];
                    arr[i, t + 1] = a;
                    arr[i, t] = b;
                }
            }
            Console.Write($" {arr[i,j], 4} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
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

int [,] array = CreateArray(4,5);
Print(array);
SortArray(array);