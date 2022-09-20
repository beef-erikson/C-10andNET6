﻿// See https://aka.ms/new-console-template for more information
using static System.Console;

int a = 3;
int b = a++; // postfix operator
WriteLine($"a is {a}, b is {b}.");

int c = 3;
int d = ++c; // prefix operator
WriteLine($"c is {c}, d is {d}.");

int e = 11;
int f = 3;
WriteLine($"\ne is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");

double g = 11.0;
WriteLine($"\ng is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}\n");

int p = 6;
p += 3; // p = p + 3
p -= 3; // p = p - 3
p *= 3; // p = p * 3
p /= 3; // p = p / 3