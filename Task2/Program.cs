/* Напишите программу, которая выводит случайное трехзначное число 
и удаляет вторую цифру этого числа. 
782 -> 72
456 -> 46
918 -> 98 */

Random rand = new Random();
int num = rand.Next(100, 1000); 
System.Console.WriteLine(num);
int num1 = num / 100;
int num2 = num % 10;
num1 = num1*10+num2;
System.Console.WriteLine(num1);