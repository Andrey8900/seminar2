﻿// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
//в которой находится эта точка.

using System;
class Program
{
static void Main()
{
Console.Write("Введите координаты точки X и Y через пробел: ");
string[] coordinates = Console.ReadLine().Split(' ');
int x = Convert.ToInt32(coordinates[0]);
int y = Convert.ToInt32(coordinates[1]);
if (x > 0 && y > 0)
Console.WriteLine("первая четверть");
else if (x < 0 && y > 0)
Console.WriteLine("вторая четверть");
else if (x < 0 && y < 0)
Console.WriteLine("третья четверть");
else if (x > 0 && y < 0)
Console.WriteLine("четвёртая четверть");
else
Console.WriteLine("Точка находится на оси координат");
}
}

