﻿Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 1;
while (count <= n)
{
if (count % 2 == 0)
    Console.Write($"{count} ");
    count++;
}
