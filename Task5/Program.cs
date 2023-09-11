/* Напишите программу, которая принимает на вход два числа 
и проверяет, является ли одно число квадратом другого.
5,25 -> да 
-4,16 -> да 
25,5 -> да 
8,9 -> нет */

Console.Write("Введите число №1: ");
string strNum1 = Console.ReadLine();
int Num1 = int.Parse(strNum1);
Console.Write("Введите число №2: ");
string strNum2 = Console.ReadLine();
int Num2 = int.Parse(strNum2);
Console.WriteLine("Вы ввели число : " +Num1+ " и " +Num2);

if(Num1 == Num2*Num2 || Num2 == Num1*Num1) 
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
