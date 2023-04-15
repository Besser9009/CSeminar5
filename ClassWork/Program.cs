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
    int SumPositiv = 0;
    int SumNegativ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0) SumPositiv += array[i];
        else SumNegativ += array[i];
    }
    Console.WriteLine($"SumPositiv = {SumPositiv}");
    Console.WriteLine($"SumNegativ = {SumNegativ}");
    return (SumNegativ, SumPositiv);
}
int []array = Array(12);
Console.WriteLine($"[{String.Join(", ", array)}]");
GetSum(array);