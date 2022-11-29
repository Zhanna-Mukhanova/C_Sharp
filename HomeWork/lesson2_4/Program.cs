//Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void Week (int day)
{
    string text = "workday";

    if (day > 5)
    {text = "weekend";}
    Console.WriteLine($"{day} = {text}");
}

Week(int.Parse(Console.ReadLine()));