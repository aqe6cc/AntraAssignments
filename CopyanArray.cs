using System;
int[] original = new int[10];
for (int i = 0; i < original.Length; i++)
    original[i] = i;
int[] copy = new int[original.Length];
for (int i = 0; i < original.Length; i++)
    copy[i] = original[i];
Console.WriteLine("Original:");
foreach (int x in original) Console.Write(x + " ");
Console.WriteLine("\nCopy:");
foreach (int x in copy) Console.Write(x + " ");