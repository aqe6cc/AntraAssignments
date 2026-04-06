//using System;
// string input = Console.ReadLine();
// char[] arr = input.ToCharArray();
// Array.Reverse(arr);
// Console.WriteLine(new string(arr));

// string input = Console.ReadLine();
// for (int i = input.Length - 1; i >= 0; i--)
//     Console.Write(input[i]);

// string sentence = Console.ReadLine();
// string[] words = sentence.Split(new char[] 
// { ' ', ',', '.', '!', '?', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/' }, 
// StringSplitOptions.RemoveEmptyEntries);
// Array.Reverse(words);
// int wordIndex = 0;
// string result = "";
// string currentWord = "";
// foreach (char c in sentence)
// {
//     if (char.IsLetterOrDigit(c) || c == '+')
//     {
//         currentWord += c;
//     }
//     else
//     {
//         if (currentWord != "")
//         {
//             result += words[wordIndex++];
//             currentWord = "";
//         }
//         result += c;
//     }
// }
// if (currentWord != "")
// {
//     result += words[wordIndex];
// }
// Console.WriteLine(result);

// string input = Console.ReadLine();
// string[] words = input.Split(new char[]
// {
//     ' ', ',', '.', '!', '?', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/'
// }, StringSplitOptions.RemoveEmptyEntries);
// HashSet<string> result = new HashSet<string>();
// foreach (string word in words)
// {
//     string reversed = new string(word.Reverse().ToArray());
//     if (word == reversed)
//         result.Add(word);
// }
// var sorted = result.OrderBy(x => x);
// Console.WriteLine(string.Join(", ", sorted));

// string url = Console.ReadLine();
// string protocol = "";
// string server = "";
// string resource = "";
// int protocolIndex = url.IndexOf("://");
// if (protocolIndex != -1)
// {
//     protocol = url.Substring(0, protocolIndex);
//     url = url.Substring(protocolIndex + 3);
// }
// int resourceIndex = url.IndexOf("/");
// if (resourceIndex != -1)
// {
//     server = url.Substring(0, resourceIndex);
//     resource = url.Substring(resourceIndex + 1);
// }
// else
// {
//     server = url;
// }
// Console.WriteLine($"protocol = \"{protocol}\"");
// Console.WriteLine($"server = \"{server}\"");
// Console.WriteLine($"resource = \"{resource}\"");