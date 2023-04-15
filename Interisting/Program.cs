Console.Clear();
int[] Array(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; ++i)
    {
        array[i] = new Random().Next(0, 20);
    }
    return array;
}
int[] array = Array(20);
Console.WriteLine($"[{String.Join(", ", array)}]");
int Diaposon(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; ++i)
    {
        if (array[i] >= 10 && array[i] <= 99) count++;
    }
    Console.WriteLine($"Колличество чисел [10, 99] = {count}");
    return count;
}
Diaposon(array);
int GetComposition(int[] array)
{
    System.Console.Write("Composition number: ");
    int Composition = 0;
    int count = array.Length - 1;
    for (int i = 0; i < array.Length / 2; i++)
    {
        Composition = array[i] * array[count];
        System.Console.Write($"{Composition}, ");
        count--;
    }
    return Composition;
}
int[] GetNewArray(int[] array)
{
    int count = array.Length - 1;
    int[] NewArray = new int[array.Length / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        NewArray[i] = array[i] * array[count];
        count--;
    }
    return NewArray;
}
GetComposition(array);
System.Console.WriteLine(" ");
int[] array2 = Array(10);
Console.WriteLine($"[{String.Join(", ", array2)}]");
GetComposition(array2);
System.Console.WriteLine(" ");
int[] NewArray = GetNewArray(array);
Console.WriteLine($"[{String.Join(", ", NewArray)}]");
