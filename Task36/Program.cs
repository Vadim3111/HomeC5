void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000); // [100, 1000]
}


int[] array = new int[10];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");