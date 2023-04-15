Console.Clear();
int [] Array(int length)
{
    int []array = new int[length];
    for (int index = 0; index < length; ++index)
    {
        array[index] = new Random().Next(-9, 10);
    }
    return array;
}
(int Positiv, int Negativ) GetSum(int []array)
{
    int SumPositive = 0;
    int SumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0) SumPositive += array[i];
        else SumNegative += array[i];
    }
    Console.WriteLine($"SumPositiv = {SumPositive}");
    Console.WriteLine($"SumNegativ = {SumNegative}");
    return (SumNegative, SumPositive);
}
int []array = Array(12);
Console.WriteLine($"[{String.Join(", ", array)}]");
GetSum(array);
int [] GetReverce(int []array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    System.Console.WriteLine($"[{String.Join(", ", array)}]");
    return array;
}
GetReverce(array);