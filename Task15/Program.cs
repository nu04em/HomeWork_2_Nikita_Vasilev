// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Clear();

// Console.Write("Введите номер дня недели: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 1 || n > 7)
//     {
//         Console.Write("Вы ошиблись!\nВведите номер дня недели: ");
//         n = int.Parse(Console.ReadLine()!);
//     }
// while (n == 6 || n == 7)
//     {
//         Console.WriteLine("Выходной!");
//         return;
//     }

// if (n == 1)
//     Console.WriteLine("Понедельник");
// else if (n == 2)
//     Console.WriteLine("Вторник");
// else if (n == 3)
//     Console.WriteLine("Среда");
// else if (n == 4)
//     Console.WriteLine("Четверг");
// else if (n == 5)
//     Console.WriteLine("Пятница");

    
// 2 Вариант

Console.Clear();

Console.Write("Введите номер выходного дня недели: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 1 || n > 7)
    {
        Console.Write("Вы ошиблись!\nВведите номер выходного дня недели: ");
        n = int.Parse(Console.ReadLine()!);
    }
if (n == 6 || n == 7)
    {
        Console.WriteLine("Да");
    }
else
    {
        Console.WriteLine("Нет");
    }