int[] GetBinaryArray(int size)
{
    int[] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next();
    }
    return result;
}

int[] myArray = GetBinaryArray(8);
Console.WriteLine($"Результат : [{String.Join(";", myArray)}]");