﻿Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

if(b * b == a)
{
    Console.WriteLine("Ура! Первое число является квадратом второго!");
}
else
{
    Console.WriteLine("Ошибка!");
}