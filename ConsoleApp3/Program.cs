int[] array = { 8, 9, 5, 6, 47, 4, 6, 9, 78, 1125 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPos = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPos]) maxPos = j;
        }

        int temp = array[i];
        array[i] = array[maxPos];
        array[maxPos] = temp;
    }
}
PrintArray(array);

SelectionSort(array);

PrintArray(array);


