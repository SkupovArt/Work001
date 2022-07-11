// Напиши программу, которая принимает два числа и отвечает, является ли первое квадратом второго
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int res = num1 / num2;


if (res == num2)
{
    Console.WriteLine($"Да, число {num1} является квадратом {num2}"); 
}
else 
{
    Console.WriteLine($"Число {num1} не является квадратом числа {num2}");
}