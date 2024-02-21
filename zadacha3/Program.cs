// Напишите программу, которая принимает на вход целое число из отрезка 
//[10, 99] и показывает наибольшую цифру числа.
using System;
class Program
{
static void Main()
{
Console.Write("Введите число из отрезка [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());
int first = number / 10;
int second = number % 10;
int max = first > second ? first : second;
Console.WriteLine(max);
}
}
