// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Summs (int num)
{
   int sum = 0;
   
    while (num !=0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }

    return sum;
}

Console.WriteLine(Summs(int.Parse(Console.ReadLine())));
