﻿// Задача 2:
// Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine($"Максимальное число {numberA} минимальное число {numberB}");   
}
else
{
    Console.WriteLine($"Максимальное число {numberB} минимальное число {numberA}");
}
