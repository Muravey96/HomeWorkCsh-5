/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.Clear();

int arraySize = new Random().Next(4, 15);
double[] array = GetArray(arraySize, 1, 99);
Console.Write(String.Join(" ", array));
double diff = CountDiffMinMax(array);
Console.WriteLine($"-> {diff}");



/////////////////
double[] GetArray (int size, int minValue, int maxValue)
{
    double[] result = new double[size];
    for (int i=0; i<size; i++)
    {
       result[i]= new Random().Next(minValue, maxValue+1);
    }
    return result;
}

/////////////////
 double CountDiffMinMax (double[] array)
{
    double diff = 0;
    double min = array[0];
    double max = array[0];
    foreach (double num in array)
    {
        if (num >= max) max=num;
        else if (num <= min ) min = num;
    }
    diff = max - min;
    return diff;
} 