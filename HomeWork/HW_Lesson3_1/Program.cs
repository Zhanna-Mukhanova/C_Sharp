// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string Palindrome (int num)
{
    if (num > 10000 && num < 100000)

    {
        int n1 = num / 10000;
        int n5 = num % 10;
        if (n1 != n5) 
        return "no";

        int n2 = (num / 1000)%10;
        int n4 = (num % 100)/10;

        if (n2 != n4) 
        return "no";

        return "It ts Palindrome";
    }  

    else
        return "Write Five-digit number";    
}


Console.WriteLine(Palindrome(int.Parse(Console.ReadLine())));
