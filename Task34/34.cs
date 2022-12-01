/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2  */

Console.Clear();

int arraySize = new Random().Next(4, 15);
int[] array = GetArray(arraySize, 100, 999);
Console.Write(String.Join(" ", array));
int evenNumbers = CountEvenNum(array);
Console.WriteLine($"-> {evenNumbers}");

/////////////////
int[] GetArray (int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i=0; i<size; i++)
    {
       result[i]= new Random().Next(minValue, maxValue+1);
    }
    return result;
}

////////////////

int CountEvenNum(int[] numbers)
{
    int amount=0;
    foreach (int num in numbers)
    {
        if (num%2 == 0) amount += 1;
    }
    return amount;
}