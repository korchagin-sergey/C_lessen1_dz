// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4->да
// - 3->нет
// 7->нет

Console.WriteLine("Введите число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

if (numberOne == 0)
{
    Console.WriteLine($"четное число = {numberOne}");
}
else
{
    if (numberOne % 2 == 0)
    {
        Console.WriteLine($"число = {numberOne} четное");
    }
    else
    {
        Console.WriteLine($"число = {numberOne} не четное");
    }
}