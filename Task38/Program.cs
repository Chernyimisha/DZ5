// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное вещественное число в массиве: ");
double minArray = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите максимальное вещественное число в массиве: ");
double maxArray = Convert.ToDouble(Console.ReadLine());
double[] array = CreateArrayRndInt(sizeArray, minArray, maxArray);
double maxElements = DifferenceMaxElements(array);
double minElements = DifferenceMinElements(array);
double differenceMaxMinElements = Math.Round((maxElements - minElements),1);

PrintArray(array);
Console.WriteLine($"Максимальный элемент: {maxElements}");
Console.WriteLine($"Минимальный элемент: {minElements}");
Console.Write($"Разница между максимальным и минимальным элементов массива -> {differenceMaxMinElements}");

double[] CreateArrayRndInt(int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble()*(max - min) + max;
        arr[i] = Math.Round(num,1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

double DifferenceMaxElements(double[] arr)
{
    double maxElem = arr[0];
    for(int i =1; i<arr.Length;i++)
    {
        if(arr[i]>maxElem) maxElem = arr[i];
    }
    return maxElem;
}

double DifferenceMinElements(double[] arr)
{
    double minElem = arr[0];
    for(int i =1; i<arr.Length;i++)
    {
        if(arr[i]<minElem) minElem = arr[i];
    }
    return minElem;
}