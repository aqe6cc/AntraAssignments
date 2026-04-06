using System;
int[] arr = { 3, 2, 4, -1 };
int k = 2;
int n = arr.Length;
int[] sum = new int[n];
for (int r = 1; r <= k; r++)
{
    int[] rotated = new int[n];

    for (int i = 0; i < n; i++)
        rotated[(i + r) % n] = arr[i];

    for (int i = 0; i < n; i++)
        sum[i] += rotated[i];
}
Console.WriteLine(string.Join(" ", sum));