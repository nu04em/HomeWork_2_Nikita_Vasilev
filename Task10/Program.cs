// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine()!);

int amount = num.ToString().Length;

if (amount > 3 || amount <3)
    {
        Console.Write("Вы ввели не трехзначное число!");
        return;
    }
else
    Console.WriteLine((num % 100)/ 10);