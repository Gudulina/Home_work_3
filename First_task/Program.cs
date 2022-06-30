/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

void Palindrome(int n)
{
    int i = 0;
    string num = n.ToString();
    int size = num.Length - 1;
    string flag = "Palindrome";

    while (i < size / 2)
    {
        if (num[i] != num[size - i])
        {
            flag = "Not a palindrome";
            break;
        }
        i++;
    }
    Console.WriteLine($"{n} - {flag}");
}

Palindrome(14212);
Palindrome(12821);
Palindrome(23432);
