//Напишите программу, которая принимает на вход трёхзначное число
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int TakeNum(int num)
{   
    Console.WriteLine(num);
    return num % 100 / 10;
}

int a = TakeNum(new Random().Next(100, 1000));
Console.WriteLine(a);




