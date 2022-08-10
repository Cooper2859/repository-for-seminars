// Задача 1

int numA;
int numB;

Console.Write("Input first number: " );
numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: " );
numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
    Console.WriteLine ($"max = {numA}");
}
else 
{
    Console.WriteLine ($"max = {numB}");
}
