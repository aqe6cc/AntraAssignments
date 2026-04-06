using System;
int[] arr = {4,1,1,4,2,3,4,4,1,2,4,9,3};
int bestNum = arr[0], bestCount = 0;
for (int i = 0; i < arr.Length; i++)
{
    int count = 0;
    for (int j = 0; j < arr.Length; j++)
        if (arr[j] == arr[i]) count++;
    if (count > bestCount)
    {
        bestCount = count;
        bestNum = arr[i];
    }
}
Console.WriteLine(bestNum);