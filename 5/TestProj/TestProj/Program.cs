//5-12

/*
* Дана матриця цілих чисел розміру M x N. Вивести номер її 1) першого; 2) останнього рядка (стовпчика), що містить максимальну кількість однакових елементів. 
*/


Console.OutputEncoding = System.Text.Encoding.Unicode; // відображення літери і

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
        
}

int[] GetNumberOfDuplicates(int[,] array)
{
    int[] duplicates = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        var dict = new Dictionary<int, int>();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            dict.TryGetValue(array[i, j], out int count);
            dict[array[i, j]] = count + 1;
        }

        int highest = 0;
        foreach (var pair in dict)
            if (pair.Value > highest) highest = pair.Value;
        duplicates[i] = highest;
    }

    return duplicates;
}

int GetFirstIndexOfMaxValue(int[] array)
{
    int index = 0, value = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > value)
        {
            index = i;
            value = array[i];
        }
    }
    return index;
}

int GetLastIndexOfMaxValue(int[] array)
{
    int index = 0, value = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= value)
        {
            index = i;
            value = array[i];
        }
    }
    return index;
}

Console.WriteLine("Введіть M(кількість рядків): ");
int M = Convert.ToInt32(Console.ReadLine());
if (M <= 0)
{
    Console.WriteLine("M має бути більшим за нуль!");
    return 1;
}
Console.WriteLine("Введіть N(кількість стовпців): ");

int N = Convert.ToInt32(Console.ReadLine());
if (N <= 0)
{
    Console.WriteLine("N має бути більшим за нуль!");
    return 1;
}

int[,] array = new int[M, N];

for (int i = 0; i < M; i++)
{
    Console.WriteLine($"Рядок {i+1}");
    for (int j = 0; j < N; j++)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        array[i, j] = number;
    }
}

Console.WriteLine("Матриця виглядає так: ");
PrintArray(array);

int[] arr = GetNumberOfDuplicates(array);

int first = GetFirstIndexOfMaxValue(arr);
// Якщо індекс - це останній рядок, то ряд одночасно перший і останній
if (first == M - 1)
{
    Console.WriteLine($"Перший: {first + 1}");
    Console.WriteLine($"Другий: {first + 1}");
    return 0;
}

int temp = arr[first];
arr[first] = 1; // important
int second = GetLastIndexOfMaxValue(arr);

// Якщо числа не рівні, то рядок під second, має менш дублікатів ніж під first.
// Отже, рядок під first одночасно перший і останній
// В іншому випадку, існує два рядка з однаковую к-істю дублікатів
if (arr[second] != temp)
{
    Console.WriteLine($"Перший: {first + 1}");
    Console.WriteLine($"Другий: {first + 1}");
}
else
{
    Console.WriteLine($"Перший: {first + 1}");
    Console.WriteLine($"Другий: {second + 1}");
}

// arr[first] = temp

return 0;