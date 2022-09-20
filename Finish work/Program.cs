/*Задача
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string[] animals = {"Cat", "Dog", "Mouse", "Pig", "Sheep", "Hen", "Cow", "Horse", "Rabbit", "Hamster"};
string[] result = new string[animals.Length];


void NewArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void Print(string[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write(mas[i]+" ");
    }
    Console.WriteLine();
}

NewArray(animals, result);
Print(animals);
Console.WriteLine();
Print(result);
