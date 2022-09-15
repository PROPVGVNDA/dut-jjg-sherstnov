//4-12

/*
Даний масив ненульових цілих чисел розміру N. 
Перевірити, чи чергуються в ньому 
1)парні та непарні і 
2) додатні і від ємні числа. 
Якщо чергуються, то вивести 0, якщо ні, то вивести номер першого елементу, що порушує закономірність. 
*/

Console.OutputEncoding = System.Text.Encoding.Unicode; // відображення літери і

bool CheckEvenOdd(int[] array)
{
    Console.WriteLine("Перевірка першої закономірності");
    for (int i = 0; i < array.Length; i += 2)
    {
        if (array[i] % 2 != 0)
        {
            Console.WriteLine($"Закономірність порушена в елементі під індексом {i}, число = {array[i]}");
            return false;
        }

        if (i + 1 < array.Length)
        {
            if (array[i + 1] % 2 == 0)
            {
                Console.WriteLine($"Закономірність порушена в елементі під індексом {i + 1}, число = {array[i + 1]}");
                return false;
            }
        }
    }
    return true;
}

bool CheckPosNeg(int[] array)
{
    Console.WriteLine("Перевірка другої закономірності");
    for (int i = 0; i < array.Length; i += 2)
    {
        if (array[i] < 0)
        {
            Console.WriteLine($"Закономірність порушена в елементі під індексом {i}, число = {array[i]}");
            return false;
        }

        if (i + 1 < array.Length)
        {
            if (array[i + 1] > 0)
            {
                Console.WriteLine($"Закономірність порушена в елементі під індексом {i + 1}, число = {array[i + 1]}");
                return false;
            }
        }
    }
    return true;
}


Console.WriteLine("Лабораторна робота 4");
Console.WriteLine("Завдання 12");

Console.WriteLine("Введіть N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N <= 0)
{
    Console.WriteLine("N має бути більшим за 0");
    return 1;
}

int[] array = new int[N];
for (int i = 0; i < N; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    if (number == 0)
    {
        Console.WriteLine("Число має бути ненульове!");
        return 1;
    }
    array[i] = number;
}

if (CheckEvenOdd(array))
    Console.WriteLine("0");

if (CheckPosNeg(array))
    Console.WriteLine("0");

return 0;