﻿/* Напишите программу, которая будет принимат на вход два числа
и выводить, является ли второе число кратным первому.
Если число 2 не кратно 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно */

System.Console.WriteLine("Введи число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введи число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num2 % num1 == 0)
{
    System.Console.WriteLine($"Кратно ");
}
else
{
    System.Console.WriteLine($"Не кратно ");
}
