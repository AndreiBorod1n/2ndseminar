﻿// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// _ _ _
// a b c = a * 100 + b*10 + c
// _ _
// a c = a*10 + c

int value = 464;

int a = value / 100; 
int c = value % 10; // Остаток от деления

int ac = a*10 + c;
Console.WriteLine(ac);