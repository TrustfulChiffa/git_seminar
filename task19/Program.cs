﻿// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да



Console.Clear();
Console.Write("Введите число от 100 до 1000");
int N = Convert.ToInt32(Console.ReadLine());
Console.Clear();
if (N > 9999 & N < 100000)
    {
        if (
            N%10 == N/10000 & (N/10)%10 == (N/1000)%10
        )
        {
            Console.WriteLine($"{N} -> да");
        }
        else
        {
            Console.WriteLine($"{N} -> нет");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели не пятизначное число. Повторите попытку.");
    
    }