//1-12

Console.OutputEncoding = System.Text.Encoding.Unicode; // відображення літери і

Console.WriteLine("Лабораторна робота 1");
Console.WriteLine("Завдання 12");
Console.WriteLine("Обчислення температури розчину води, одержаної при змішуванні " +
    "v1 літрів води температури t1, та v2 літрів води температури t2");

double v1, v2, t1, t2;

Console.WriteLine("Enter v1(in litres): ");
v1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter v2(in litres): ");
v2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter t1: ");
t1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter t2: ");
t2 = Convert.ToDouble(Console.ReadLine());

double result = (v1 * t1 + v2 * t2) / (v1 + v2);
Console.WriteLine(Math.Round(result, 1));

//2-12

Console.WriteLine("Лабораторна робота 2");
Console.WriteLine("Завдання 12");

double CalculateFormula(int k)
{
    double numerator = 3 * k + (Math.Pow(-1, Math.Pow(k, 2) - k + 1) * k);
    double denominator = 2 * Math.Pow(k, 2) + 1;
    return numerator / denominator;
}

Console.WriteLine("Enter nn: ");
int nn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter nk: ");
int nk = Convert.ToInt32(Console.ReadLine());
result = 1;


if (nn < 0 || nn > nk)
{
    Console.WriteLine("nn should be greater or equal to 0 and nn should be less or equal to nk");
    return 1;
}

for (int k = nn; k <= nk; k++)
    result *= CalculateFormula(k);

Console.WriteLine(result);

return 0;


