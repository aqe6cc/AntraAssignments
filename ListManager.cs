using System;
List<string> list = new List<string>();
while (true)
{
    Console.WriteLine("Enter command (+ item, - item, -- to clear):");
    string input = Console.ReadLine();
    if (input.StartsWith("+ "))
        list.Add(input.Substring(2));
    else if (input.StartsWith("- "))
        list.Remove(input.Substring(2));
    else if (input == "--")
        list.Clear();
    Console.WriteLine("Current list:");
    foreach (var item in list)
        Console.WriteLine(item);
}