//Напишите программу, которая выводит третью цифру
//заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

string n = Console.ReadLine();

int t = int.Parse(n);

if (t <= 99)
{
    Console.WriteLine("Нет Третьего числа");
    return;
}

else
{
    while (t > 999) t /= 10;
    Console.WriteLine(t % 10);
}


