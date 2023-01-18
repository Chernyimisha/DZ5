// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[8];

FillArray(array);
int sum = EvenNumbers(array);
PrintArray(array);
Console.Write($" -> {sum}");

void FillArray(int[] collection)
{
    int length = collection.Length;
    Random rnd = new Random();
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count-1)
    {
        Console.Write($"{col[position]},");
        position++;
    }
    Console.Write($"{col[count-1]}");
    Console.Write("]");
}

int EvenNumbers(int[] arr)
{
    int result = 0;
    for(int i=0; i<arr.Length;i++)
    {
        if(arr[i]%2==0) result++;
    }
    return result;
}