﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число "); 
int number1 = Convert.ToInt32(Console.ReadLine());
if ( number1 >= 100 & number1 <= 999)
{
int number = number1 / 10 % 10;
Console.WriteLine($"Вторая цифра числа: {number}");
}
else 
{
  Console.WriteLine("Ошибка. Введите трёхзначное число");  
}
