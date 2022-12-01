/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0  */

Console.Clear();

int arraySize = new Random().Next(4, 15);
int[] array = GetArray(arraySize, 1, 1000);
Console.Write(String.Join(" ", array));
int unevenIndex = CountNumUnevenIn(array);
Console.WriteLine($"-> {unevenIndex}");



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

int CountNumUnevenIn(int [] array)
{
    int sum = 0;
    for (int i = 1; i< array.Length; i+=2 )
    {
        sum+= array[i]; 
    }
    return sum;
}

