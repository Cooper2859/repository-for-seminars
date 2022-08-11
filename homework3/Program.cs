// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine ("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
    
        if (n % 2 == 0)
        Console.WriteLine("число четное");
    else
    Console.WriteLine("число нечетное");