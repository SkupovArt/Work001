﻿// Программа, которая выдает введенному числу день недели
Console.Write ("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
   Console.Write("Понедельник");
}
else if (num == 2)
{
    Console.Write("Вторник");
}
else if (num == 3)
{
    Console.Write("Среда");
}
else if (num == 4)
{
    Console.Write("Четверг");
}
else if (num == 5)
{
    Console.Write("Пятница");
}
else if (num == 6)
{
    Console.Write("Суббота");
}
else if (num == 7)
{
    Console.Write("Воскресенье");
}
else 
{
    Console.Write("Вы ввели число не от 1 до 7, повторите попытку");
}
