/* Напишите программу, которая принимает на вход число 
и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да */

/* 
while(true)
{
    Console.Write("Введите число: ");
    try
    {
        int num = int.Parse(Console.ReadLine());
        if(num % 7 == 0 && num % 23 == 0)
            Console.WriteLine("Число кратно 7 и 23");
        else
        {
            Console.WriteLine("Число не кратно 7 и 23");
        }
    }
    catch(Exception e)
    {
        Console.WriteLine("Неверный ввод");
    }
}
*/

while(true)
{
    Console.Write("Введите число: ");
    
        int num = int.Parse(Console.ReadLine());
        if(num % 7 == 0 && num % 23 == 0)
            Console.WriteLine("Число кратно 7 и 23");
        else
            Console.WriteLine("Число не кратно 7 и 23");
}
