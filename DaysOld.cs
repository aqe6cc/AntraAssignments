using System;
DateTime birthDate = new DateTime(2003, 3, 8);
int days = (DateTime.Now - birthDate).Days;

Console.WriteLine(days);

int next = 10000 - (days % 10000);
Console.WriteLine($"Next anniversary in {next} days");