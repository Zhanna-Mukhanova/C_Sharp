/* Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] CreateArray(int m, int n) {
    int[,] array = new int[m, n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            array[i,j] = new Random().Next(0, 10);
        }
    }
    return array;
}

int[,] MultiplyArray(int[,] arr1, int[,] arr2){
    int min_sum = 0;
    int min_row_num = 0;
    int row_size = arr1.GetLength(0);
    int col_size = arr1.GetLength(1);
    int[,] multi = new int [row_size, row_size];
    if(row_size != arr2.GetLength(1) || col_size != arr2.GetLength(0))
        return multi;

    for(int i = 0; i < row_size; i++) 
    {   
        for(int j = 0; j < row_size; j++) 
        {   
            int row_sum = 0;
            for(int k = 0; k < col_size; k++){
                row_sum = arr1[i,k] * arr2[k,j] + row_sum;
            }
            multi[i,j] = row_sum;
        }
    }

    return multi;
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

int [,] array1 = CreateArray(2,2);
int [,] array2 = CreateArray(2,2);
Print(array1);
Print(array2);
Print(MultiplyArray(array1, array2));