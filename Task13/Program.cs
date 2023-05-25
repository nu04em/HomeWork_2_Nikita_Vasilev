// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры 

Console.Clear();

Console.Write("Введите число: ");
string value = Console.ReadLine();
int num = int.Parse(value!);

while (num < 100) 
    {
        Console.Write("В указанном числе нет третьей цифры!\nВведите другое число: ");
        value = Console.ReadLine();
        num = int.Parse(value!);
    }

Console.WriteLine(int.Parse(value.Remove(3))%10);
return;