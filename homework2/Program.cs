// Задача 2
int numB;
int numC;
int numA;
int max;

Console.Write("Input first number: " );
numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: " );
numB = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third number: " );
numC = Convert.ToInt32(Console.ReadLine());

max = numA;
if (numB > numA) max = numB;
if (numC > max) max = numC;
{
    Console.WriteLine (max);
}
