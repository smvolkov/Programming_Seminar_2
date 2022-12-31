// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

void Task1()
{
    Console.WriteLine("Введите трехзначное число: ");
    string number = Console.ReadLine();

    Console.WriteLine(number[1]);
} 

//Task1();

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void Task2()
{
    Console.WriteLine("Введите число: ");
    string N = Console.ReadLine();

    if (N.Length > 2) Console.WriteLine(N[2]);
    else Console.WriteLine("Третьей цифры нет");
}

Task2();