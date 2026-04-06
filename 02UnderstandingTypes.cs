using System;

Console.WriteLine("02UnderstandingTypesQ1");
Console.WriteLine($"sbyte: {sizeof(sbyte)} bytes, Min: {sbyte.MinValue}, Max: {sbyte.MaxValue}");
Console.WriteLine($"byte: {sizeof(byte)} bytes, Min: {byte.MinValue}, Max: {byte.MaxValue}");
Console.WriteLine($"short: {sizeof(short)} bytes, Min: {short.MinValue}, Max: {short.MaxValue}");
Console.WriteLine($"ushort: {sizeof(ushort)} bytes, Min: {ushort.MinValue}, Max: {ushort.MaxValue}");
Console.WriteLine($"int: {sizeof(int)} bytes, Min: {int.MinValue}, Max: {int.MaxValue}");
Console.WriteLine($"uint: {sizeof(uint)} bytes, Min: {uint.MinValue}, Max: {uint.MaxValue}");
Console.WriteLine($"long: {sizeof(long)} bytes, Min: {long.MinValue}, Max: {long.MaxValue}");
Console.WriteLine($"ulong: {sizeof(ulong)} bytes, Min: {ulong.MinValue}, Max: {ulong.MaxValue}");
Console.WriteLine($"float: {sizeof(float)} bytes, Min: {float.MinValue}, Max: {float.MaxValue}");
Console.WriteLine($"double: {sizeof(double)} bytes, Min: {double.MinValue}, Max: {double.MaxValue}");
Console.WriteLine($"decimal: {sizeof(decimal)} bytes, Min: {decimal.MinValue}, Max: {decimal.MaxValue}");

Console.WriteLine("02UnderstandingTypesQ2");
int centuries = int.Parse(Console.ReadLine());
long years = centuries * 100;
long days = (long)(years * 365.2422);
long hours = days * 24;
long minutes = hours * 60;
long seconds = minutes * 60;
long milliseconds = seconds * 1000;
long microseconds = milliseconds * 1000;
long nanoseconds = microseconds * 1000;
Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds}");