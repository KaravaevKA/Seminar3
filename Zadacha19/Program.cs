﻿
Console.WriteLine("Введите число");
string Num = Console.ReadLine();
if (Num[0]==Num[4] && Num[1]==Num[3])
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}