/* Задача 2: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

void MinSumRow(int[,] arr){
    int min_sum = 0;
    int min_row_num = 0;
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
    for(int i = 0; i < row_size; i++) 
    {
        int row_sum = 0;
        for(int j = 0; j < col_size; j++){
            row_sum = arr[i,j] + row_sum;
        }
        if(row_sum < min_sum) {
            min_row_num = i;
            min_sum = row_sum;
        }
    }

    Console.WriteLine("Строка с минимальной суммой:");
    for(int j = 0; j < col_size; j++){
        Console.Write($"{arr[min_row_num,j], 4} ");
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
MinSumRow(array);