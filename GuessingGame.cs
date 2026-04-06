//Guessing Game

using System;
int correctNumber = new Random().Next(3) + 1;
int guess = int.Parse(Console.ReadLine());
if (guess < 1 || guess > 3)
    Console.WriteLine("Out of range");
else if (guess < correctNumber)
    Console.WriteLine("Too low");
else if (guess > correctNumber)
    Console.WriteLine("Too high");
else
    Console.WriteLine("Correct!");