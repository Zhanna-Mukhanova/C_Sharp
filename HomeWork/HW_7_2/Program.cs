/*
Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
        double 
        double sum = 0;
        for(int j = 0; j < col_size; j++) 
        {
            sum = sum + a[i,j]; 
        }
        double avg = sum / c
        Console.Write();

        
Console.WriteLine("Введите число для поиска в массиве");
int searchElement = int.Parse(Console.ReadLine());
int[,] array = createArray(10,20);
Print(array);
FindElement(array, searchElement);

int[,] createArray(int m, int n){
    int[,] array = new int[m, n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            array[i,j] = new Random().Next(-100, 100);
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


void FindElement(int[,] arr, int searchElement){
    int row_size = arr.GetLength(0);
    int col_size = arr.GetLength(1);
    int flag = 0;
    Console.Write("Позиция элемента ");
    for(int i = 0; i < row_size; i++) 
    {
        for(int j = 0; j < col_size; j++){
            if( arr[i,j] == searchElement){
                Console.Write($" ({i},{j}) ");
                flag++;
            }
        }
    }
    if(flag == 0){
        Console.Write(" не найдена");
    }
}