// Напишите программу, которая принимает
// на вход число (Ф) и выдает сумму чисел от 1 до А.

int SunNums(int num)
{
    int all_sum = 0;
    For (int i = 1; i <= num;  i++)
    {
        all_sum += i;
    }

    return all_sum;
}

Console.WriteLine(SunNums(int.Parse(Console.ReadLine())));

int i = 0;

i++;
i += 1;
i = i +1;