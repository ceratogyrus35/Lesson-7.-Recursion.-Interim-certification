// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];

    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array, int i = 0)
{
    if (i < array.Length)
    {
        Console.Write($"{array[i]} ");
        PrintArray(array, i + 1);
    }
}

void PrintReverseArray(int[] array, int count)
{
    if (count == 0) return;
    {
        Console.Write($"{array[count-1]} ");
        PrintReverseArray(array, count-1);
    }
}


Console.Write("Введите колличество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] arrayMain = CreateArrayRndInt(size, min, max);
PrintArray(arrayMain);
Console.Write("=> ");
PrintReverseArray(arrayMain, arrayMain.Length);