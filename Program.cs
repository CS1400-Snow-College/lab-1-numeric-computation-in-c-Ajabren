﻿// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Hello, World!");
decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");
double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);

Console.WriteLine("Now Let's get down to business!");

double e = 2.50;
double f = ((e * e) * Math.PI);
Console.WriteLine(f);
