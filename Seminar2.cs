﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

void Task1()
{
    Console.WriteLine("Введите число: ");
    string number = Console.ReadLine();

    Console.WriteLine(number[1]);
} 

Task1();

