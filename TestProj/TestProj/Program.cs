//Rectangle

int GetPerimiter(int a, int b)
{
    return 2 * (a + b);
}

double GetArea(int a, int b)
{
    return a * b;
}

double GetDiagonal(int a, int b)
{
    return Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));
}

bool IsSquare(int a, int b)
{
    return a == b;
}

Console.Write("Enter first side of rectangle: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second side of rectangle: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Perimeter: {GetPerimiter(a, b)}");
Console.WriteLine($"Area: {GetArea(a, b)}");
Console.WriteLine($"Diagonl: {GetDiagonal(a, b)}");
Console.WriteLine($"Is square: {IsSquare(a, b)}");
