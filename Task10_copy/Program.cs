// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine()!);

while (num < 100 || num > 999)
    {
        Console.Write("Вы ввели не трёхзначное число!\nВведите трёхзначное число: ");
        num = int.Parse(Console.ReadLine()!);
    }
Console.WriteLine($"Второе число: " + (num % 100)/ 10);
return;
