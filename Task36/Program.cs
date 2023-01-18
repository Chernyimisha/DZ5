// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[8];

FillArray(array);
int sum = SumElementsOddPositions(array);
PrintArray(array);
Console.Write($" -> {sum}");

void FillArray(int[] collection)
{
    int length = collection.Length;
    Random rnd = new Random();
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(-100, 100);
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

int SumElementsOddPositions(int[] arr)
{
    int result = 0;
    for(int i=1; i<arr.Length;i=i+2)
    {
        result+=arr[i];
    }
    return result;
}