/****************************************************************************************************************
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*******************************************************************************************************************/
/*
Console.WriteLine("Введите первое число: ");
int Num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int Num2 = int.Parse(Console.ReadLine()!);

if(Num1 > Num2) {
    Console.WriteLine($"max = {Num1}");
}
if(Num1 < Num2) {
    Console.WriteLine($"max = {Num2}");
}
if(Num1 == Num2) {
    Console.WriteLine("Числа равны");
}
*/
/****************************************************************************************************************
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*******************************************************************************************************************/
/*
Console.WriteLine("Введите первое число ");
int Num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число ");
int Num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число ");
int Num3 = int.Parse(Console.ReadLine()!);
int max = Num1;

if (Num1 > Num2)
{
    max = Num1;
}
else
{
    max = Num2;
}
if (Num1 > Num3)
{
    max = Num1;
}
else
{
    max = Num3;
}
if (Num2 > Num3)
{
    max = Num2;
}
else
{
    max = Num3;
}
Console.WriteLine($"максимальное число {max}");
*/
/****************************************************************************************************************
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*******************************************************************************************************************/
/*
Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine()!);

if (Number % 2 == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является нечетным");
}
*/
/****************************************************************************************************************
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*******************************************************************************************************************/

Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine()!);
int NumberOutput = 1;

while (NumberOutput <= Number)
{
    if (NumberOutput % 2 == 0)
    {
        Console.Write($"{NumberOutput}, ");
        NumberOutput++;
    }
     else
    {
        NumberOutput++;
    }
}
Console.WriteLine();