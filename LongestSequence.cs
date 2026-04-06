using System;
int[] arr = { 2,1,1,2,3,3,2,2,2,1 };
int bestLen = 1, bestNum = arr[0];
int currLen = 1;
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] == arr[i - 1])
        currLen++;
    else
        currLen = 1;

    if (currLen > bestLen)
    {
        bestLen = currLen;
        bestNum = arr[i];
    }
}
for (int i = 0; i < bestLen; i++)
    Console.Write(bestNum + " ");