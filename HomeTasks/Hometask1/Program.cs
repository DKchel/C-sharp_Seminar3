﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((0 < num / 10000) && (num / 10000 < 10 ))
{
    if ((num / 10000 == num % 10) && (num / 1000 % 10 == num / 10 % 10))
    {
        Console.WriteLine($"Число {num} является полидромом");
    }

    else
    {
        Console.WriteLine($"Число {num} не является полидромом");
    }
}
else
{
    Console.WriteLine("Введено не пятизначное число");
}