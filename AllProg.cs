/*
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// _ _ _
// a b c = a * 100 + b*10 + c
// _ _
// a c = a*10 + c

int value = 464;

int a = value / 100; 
int c = value % 10; // Остаток от деления

int ac = a*10 + c;
Console.WriteLine(ac);
*/

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

bool Check(int value)
{
    return value % 7 == 0 && value % 23 == 0;
}
Console.Write("a =");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Check(a));
