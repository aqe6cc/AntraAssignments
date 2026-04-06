//Pyramid

using System;
for (int i = 1; i <= 5; i++)
{
    for (int j = 5 - i; j > 0; j--)
        Console.Write(" ");
    for (int k = 0; k < i * 2 - 1; k++)
        Console.Write("*");
    Console.WriteLine();
}