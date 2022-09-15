//3-12

Console.OutputEncoding = System.Text.Encoding.Unicode; // відображення літери і

Console.WriteLine("Лабораторна робота 3");
Console.WriteLine("Завдання 12");
Console.WriteLine("Перевірити істинність вислову: \"Всі цифри даного тризначного числа різні\"");

Console.WriteLine("Введіть тризначне число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a, b, c;

if (number >= 0)
{
    if (number < 100 || number > 999)
    {
        Console.WriteLine("Введене число не є тризначним");
        return 1;
    }
}
else
{
    if (number < -999 || number > -100)
    {
        Console.WriteLine("Введене число не є тризначним");
    }
}


a = Math.Abs(number % 10);
b = Math.Abs(number / 10 % 10);
c = Math.Abs(number / 100);

Console.WriteLine($"Перша цифра: {c}");
Console.WriteLine($"Друга цифра: {b}");
Console.WriteLine($"Третя цифра: {a}");

if (a != b)
{
    if (a != c)
    {
        if (b != c)
        {
            Console.WriteLine("True");
            return 0;
        }
    }
}

Console.WriteLine("False");
return 1;